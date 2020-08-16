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

        public CelestialObjectController (ApplicationDbContext _Context) => _context = _Context;

        private ApplicationDbContext _context
        {
            get;
            set;

        }
    }
}
