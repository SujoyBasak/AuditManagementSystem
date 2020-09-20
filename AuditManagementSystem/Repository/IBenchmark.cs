using AuditManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditManagementSystem.Repository
{
    public interface IBenchmark
    {
        public List<AuditBenchmark> GetNolist();
    }
}
