using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_MVC_CORE.Models
{
    public class ConnectionStringClass: DbContext
    {
        public ConnectionStringClass( DbContextOptions<ConnectionStringClass> options):base(options)
        {
                
        }
        public DbSet<EmpClass> EmpDetails { get; set; }
    }
}
