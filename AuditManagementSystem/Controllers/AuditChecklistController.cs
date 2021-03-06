﻿using System;
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
    public class AuditChecklistController : ControllerBase
    {
        // GET: api/AuditChecklist
        [HttpGet]
        public IActionResult Get([FromBody]AuditType auditType)
        {
            Checklist obj = new Checklist();
            var list=obj.GetQuestions(auditType);
            if (list != null)
                return Ok(list);

            return Ok("Wrong Input");
        }        
    }
}
