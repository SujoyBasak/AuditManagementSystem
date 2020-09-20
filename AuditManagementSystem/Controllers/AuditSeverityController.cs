using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AuditManagementSystem.Models;
using AuditManagementSystem.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AuditManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditSeverityController : ControllerBase
    {

        
        // GET: api/AuditBenchmark
        //[HttpGet]
        //public IActionResult Get()
        //{
            
        //}

        // POST: api/AuditSeverity
        [HttpPost]
        public void Post()
        {
            Severity obj = new Severity();
            obj.Response(new AuditRequest());
             

        }

        
    }
}
