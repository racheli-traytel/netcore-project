using dress_rent.core.interfaces.services_interfaces;
using dress_rent.entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dress_rent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DressController : ControllerBase
    {
        readonly IDressService dressService;

        public DressController(IDressService dressService)
        {
            this.dressService = dressService;
        }

        // GET: api/<DressController>
        [HttpGet]
        public ActionResult<List<DressEntity>> Get()
        {
            return dressService.GetList();

        }

        // GET api/<DressController>/5
        [HttpGet("{id}")]
        public ActionResult<DressEntity> GetId(int id)
        {
            if (id < 0) return BadRequest();
            DressEntity result = dressService.GetById(id);
            if (result == null) { return NotFound(); }
            return result;
        }

        // POST api/<DressController>
        [HttpPost]
        public ActionResult Post([FromBody] DressEntity d)
        {
            bool success = dressService.AddDress(d);
            if (!success) return BadRequest();
            return Ok(success);
        }

        // PUT api/<DressController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] DressEntity d)
        {
            if (id < 0) return BadRequest();
            bool flag = dressService.Update(id, d);
            if (!flag) { return NotFound(); }
            return Ok(flag);

        }

        // DELETE api/<DressController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id < 0) return BadRequest();
            bool sucess = dressService.Remove(id);
            if (!sucess) return NotFound();
            return Ok(sucess);
        }
    }
}
