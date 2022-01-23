using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceWebMvc.Models;

namespace ServiceWebMvc.Data
{
    public class ServiceWebMvcContext : DbContext
    {
        public ServiceWebMvcContext (DbContextOptions<ServiceWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<ServiceWebMvc.Models.Department> Department { get; set; }
    }
}
