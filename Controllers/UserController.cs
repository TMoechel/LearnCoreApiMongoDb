using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UserApi.Vm;

namespace UserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<UserData>> Get()
        {
            return new List<UserData>() { 
                new UserData() {Oid = 1, FirstName = "Mike", LastName = "Miller"},
                new UserData() {FirstName = "Peter", LastName = "Jordan"},

             };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<UserData> Get(int id)
        {
            return new UserData() {Oid = 2, FirstName = "Mike", LastName = "Miller"};
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
