using AuditManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditManagementSystem.Repository
{
    public interface ISeverity
    {
        public AuditResponse Response(AuditRequest request);
    }
}
