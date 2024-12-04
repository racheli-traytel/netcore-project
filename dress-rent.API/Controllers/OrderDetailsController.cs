using dress_rent.core.interfaces.services_interfaces;
using dress_rent.entities;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dress_rent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        readonly IOrder_DetailsService order_detail_service;

        public OrderDetailsController(IOrder_DetailsService order_detail_service)
        {
            this.order_detail_service = order_detail_service;
        }

        // GET: api/<DressController>
        [HttpGet]
        public ActionResult<List<Order_DetailsEntity>> Get()
        {
            return order_detail_service.GetList();


        }

        // GET api/<DressController>/5
        [HttpGet("{id}")]
        public ActionResult<Order_DetailsEntity> GetId(int id)
        {
            if (id < 0) return BadRequest();
            Order_DetailsEntity result = order_detail_service.GetById(id);
            if (result == null) { return NotFound(); }
            return result;
        }

        // POST api/<DressController>
        [HttpPost]
        public ActionResult Post([FromBody] Order_DetailsEntity d)
        {
            bool success = order_detail_service.AddOrder_Details(d);
            return Ok(success);

        }

        // PUT api/<DressController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Order_DetailsEntity d)
        {
            if (id < 0) return BadRequest();
            bool flag = order_detail_service.Update(id, d);
            if (!flag) { return NotFound(); }
            return Ok(flag);

        }

        // DELETE api/<DressController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id < 0) return BadRequest();
            bool sucess = order_detail_service.Remove(id);
            if (!sucess) { return NotFound(); }
            return Ok(sucess);
        }
    }
}
