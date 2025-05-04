using BulkyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sd7501Bulky.DataAccess.Repository.IRepository
{
   public interface ICategoryRepository:IRepository<Category>
    {
        void Update(Category obj);
      
    }
}
