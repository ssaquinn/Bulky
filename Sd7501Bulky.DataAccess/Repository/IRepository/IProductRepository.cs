﻿using BulkyWeb.Models;
using SD7501Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sd7501Bulky.DataAccess.Repository.IRepository
{
   public interface IProductRepository:IRepository<Product>
    {

        void Update(Product obj);
        void Save();
      
    }
}
