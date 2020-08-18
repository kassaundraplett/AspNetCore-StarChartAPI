using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

namespace StarChart.Controllers
{
    [ApiController]
    [Route("")]
    public class CelestialObjectController : ControllerBase
    {       

        private readonly  ApplicationDbContext _context;
  
        public CelestialObjectController (ApplicationDbContext context) => _context = context;

        [HttpGet("{id:int}/Name/{GetByID}")]
        public IActionResult GetId(int id)
            {          
                return this.NotFound();
            }

        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
            {
                return this.NotFound();
            }
            
        [HttpGet]
        public IActionResult GetAll(int id)
            {
                return Ok();
            }
    }
}
