using ServiceWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceWebMvc.Services
{
    public class DepartmentService
    {

        private readonly ServiceWebMvcContext _context;

        public DepartmentService(ServiceWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
