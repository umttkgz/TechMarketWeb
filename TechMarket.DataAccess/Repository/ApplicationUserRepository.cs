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
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private AppDbContext _db;
        public ApplicationUserRepository(AppDbContext db): base(db)
        {
            _db = db;
        }
    }
}
