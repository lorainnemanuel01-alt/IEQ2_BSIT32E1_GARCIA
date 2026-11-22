using IEQ2_BSIT32E1_GARCIA.Model.Users;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IEQ2_BSIT32E1_GARCIA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get(int id)
        {
            if (id>2)
            {
                return NotFound();
            }

            if (id==0)
            {
                return BadRequest();
            }

            if (id<0)
            {
                return NoContent();
            }

            var value = new GetUsersResponse();
            value.Users.Add(new GetUserDto
            {
                Id = 2,
                Name = "Garcia",
                Email = "garcia@example.com"
            }
            );

            var response = value.Users.FirstOrDefault(x => x.Id == id);                                                                                                                                                                                                                                                               
            return Ok(response);
        }

      

        // POST api/<UserController>
        [HttpPost]
        public IActionResult  Post([FromBody] CreateUserRequest value)
        {
            return Ok(value);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
