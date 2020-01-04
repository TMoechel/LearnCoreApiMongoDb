using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UserApi.Vm;
using UserApi.Services;

namespace UserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly AddressService addressService;
        public AddressController(AddressService _addressService) {
            addressService = _addressService;
        }
       
        // GET api/address
        [HttpGet]
        public ActionResult<IEnumerable<Address>> Get()
        {
            return addressService.Get();
        }
        
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
