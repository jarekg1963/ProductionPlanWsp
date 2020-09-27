using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductionPlanWsp.Server.Data;
using ProductionPlanWsp.Shared;

namespace ProductionPlanWsp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class planningProductionController : ControllerBase
    {
        private readonly PlanowanieContext _context;

        public planningProductionController(PlanowanieContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VwPlanningProduction>>> planningProduction()
        {
            return await _context.VwPlanningProduction.ToListAsync();
        }
    }
}
