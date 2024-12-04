using dress_rent.core.interfaces.services_interfaces;
using dress_rent.entities;


using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dress_rent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        readonly IOrderService order_service;

        public OrderController(IOrderService order_service)
        {
            this.order_service = order_service;
        }

        // GET: api/<DressController>
        [HttpGet]
        public ActionResult<List<orderEntity>> Get()
        {
            return order_service.GetList();


        }

        // GET api/<DressController>/5
        [HttpGet("{id}")]
        public ActionResult<orderEntity> GetId(int id)
        {
            if (id < 0) return BadRequest();
            orderEntity result = order_service.GetById(id);
            if (result == null) { return NotFound(); }
            return result;
        }

        // POST api/<DressController>
        [HttpPost]
        public ActionResult Post([FromBody] orderEntity d)
        {
            bool success = order_service.AddOrder(d);
            return Ok(success);

        }

        // PUT api/<DressController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] orderEntity d)
        {
            if (id < 0) return BadRequest();
            bool flag = order_service.Update(id, d);
            if (!flag) { return NotFound(); }
            return Ok(flag);

        }

        // DELETE api/<DressController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id < 0) return BadRequest();
            bool sucess = order_service.Remove(id);
            if (!sucess) { return NotFound(); }
            return Ok(sucess);
        }
    }
}
