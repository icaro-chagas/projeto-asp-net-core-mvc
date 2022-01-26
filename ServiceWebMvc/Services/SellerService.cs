using ServiceWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceWebMvc.Services
{
    public class SellerService
    {
        private readonly ServiceWebMvcContext _context;

        public SellerService(ServiceWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        { 
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
