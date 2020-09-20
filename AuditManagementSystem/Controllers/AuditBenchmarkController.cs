using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuditManagementSystem.Models;
using AuditManagementSystem.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuditManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditBenchmarkController : ControllerBase
    {
        // GET: api/AuditBenchmark
        [HttpGet]
        public IEnumerable<AuditBenchmark> Get()
        {
            BenchmarkRepo obj = new BenchmarkRepo();
            return obj.GetNolist();
        }
       
    }
}
