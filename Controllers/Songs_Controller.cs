using Microsoft.AspNetCore.Mvc;
using Music_Library_WebAPI.Data;
using Music_Library_WebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Music_Library_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Songs_Controller : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public Songs_Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<Songs_Controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Songs_Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Songs_Controller>
        [HttpPost]
        public IActionResult POST([FromBody] Song song)

        {
            _context.Songs.Add(song);
            _context.SaveChanges();

            return StatusCode(201, song);
        }

        // PUT api/<Songs_Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Songs_Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
