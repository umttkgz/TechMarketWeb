﻿using Microsoft.EntityFrameworkCore;
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
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private AppDbContext _db;
        public ShoppingCartRepository(AppDbContext db): base(db)
        {
            _db = db;
        }
        public void Update(ShoppingCart obj)
        {
            _db.ShoppingCarts.Update(obj);
        }
    }
}
