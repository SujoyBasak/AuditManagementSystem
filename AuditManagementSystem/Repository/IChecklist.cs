using AuditManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditManagementSystem.Repository
{
    public interface IChecklist
    {
        public List<Questions> GetQuestions(AuditType auditType);
    }
}
