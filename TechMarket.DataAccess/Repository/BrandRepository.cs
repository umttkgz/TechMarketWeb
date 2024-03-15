using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TechMarket.DataAccess.Data;
using TechMarket.DataAccess.Repository.IRepository;
using TechMarket.Models;

namespace TechMarket.DataAccess.Repository
{
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        private AppDbContext _db;
        public BrandRepository(AppDbContext db): base(db)
        {
            _db = db;
        }
        public void Update(Brand obj)
        {
            _db.Brands.Update(obj);
        }
    }
}
