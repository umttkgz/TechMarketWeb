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
    public class SubCategoryRepository : Repository<SubCategory>, ISubCategoryRepository
    {
        private AppDbContext _db;
        public SubCategoryRepository(AppDbContext db): base(db)
        {
            _db = db;
        }
        public void Update(SubCategory obj)
        {
            _db.SubCategories.Update(obj);
        }
    }
}
