
using dress_rent.core.entities;
using dress_rent.core.interfaces.services_interfaces;
using dress_rent.entities;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dress_rent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        readonly ICustomerService customer_service;

        public CustomerController(ICustomerService customer_service)
        {
            this.customer_service = customer_service;
        }
        // GET: api/<DressController>
        [HttpGet]
        public ActionResult<List<CustomerEntity>> Get()
        {
            return customer_service.GetList();
        }

        // GET api/<DressController>/5
        [HttpGet("{id}")]
        public ActionResult<CustomerEntity> GetId(int id)
        {
            if (id < 0) return BadRequest();
            CustomerEntity result = customer_service.GetById(id);
            if (result == null) { return NotFound(); }
            return result;
        }

        // POST api/<DressController>
        [HttpPost]
        public ActionResult Post([FromBody] CustomerEntity d)
        {
            //if (!Validation.IsValidEmail(d.Email) || !Validation.IsValidPhoneNumber(d.Phone))
            //    return BadRequest();
            bool success = customer_service.AddCustomer(d);
         
                if (!success) { return BadRequest(); }
            return Ok(success);
        }

        // PUT api/<DressController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CustomerEntity d)
        {
            if (id < 0) return BadRequest();
            //if (!Validation.IsValidEmail(d.Email) || !Validation.IsValidPhoneNumber(d.Phone))
            //    return BadRequest();
            bool flag = customer_service.Update(id, d);
            if (!flag) { return NotFound(); }
            else
            {
                return Ok(true);
            }
        }

        // DELETE api/<DressController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id < 0) return BadRequest();
            bool sucess = customer_service.Remove(id);
            if (!sucess) { return NotFound(); }
            else { return Ok(true); }
        }
    }
}
