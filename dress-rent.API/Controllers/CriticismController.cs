using dress_rent.core.interfaces.services_interfaces;
using dress_rent.entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dress_rent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CriticismController : ControllerBase
    {
        readonly ICriticismService _criticismService;

        public CriticismController(ICriticismService criticismService)
        {
            _criticismService = criticismService;
        }

        //GET:api/<DressController>
        [HttpGet]
        public ActionResult<List<CriticismEntity>> Get()
        {
            return _criticismService.GetList();
        }

        //GET api/<DressController>/5
        [HttpGet("{id}")]
        public ActionResult<CriticismEntity> GetId(int id)
        {
            if (id < 0) return BadRequest();
            CriticismEntity result = _criticismService.GetById(id);
            if (result == null) { return NotFound(); }
            return result;
        }

        // POST api/<DressController>
        [HttpPost]
        public ActionResult Post([FromBody] CriticismEntity d)
        {
            if (d == null)
                return BadRequest();
            bool success = _criticismService.AddCriticism(d);
            return Ok(success);
        }

        // PUT api/<DressController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CriticismEntity d)
        {
            if (id < 0) return BadRequest();
            bool flag = _criticismService.Update(id,d);
            if (!flag) { return NotFound(); }
            return Ok(flag);
        }

        // DELETE api/<DressController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)

        {
            if (id < 0) return BadRequest();
            bool sucess = _criticismService.Remove(id);
            if (!sucess) return NotFound();
            return Ok(sucess);
        }
    }
}

