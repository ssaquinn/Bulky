﻿using Bulky.DataAccess.Repository;
using BulkyWeb.Data;
using BulkyWeb.Models;
using Sd7501Bulky.DataAccess.Repository.IRepository;
using Sd7501Bulky.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Save()
        {
            _db.SaveChanges();
        }
        public void Update(Category obj)
        {
            _db.Update(obj);
        }

    }
}