using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductionPlanWsp.Server.Data;
using ProductionPlanWsp.Shared;

namespace POProductionController.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class POProductionController : ControllerBase
    {
        private readonly PlanowanieContext _context;

        public POProductionController(PlanowanieContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VwPoPlanningProduction>>> POplanningProduction()
        {
            return await _context.VwPoPlanningProduction.ToListAsync();
        }
    }
}
