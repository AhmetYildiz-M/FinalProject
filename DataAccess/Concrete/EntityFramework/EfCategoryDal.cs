using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return null;
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            return null;
        }

        public void Add(Category entity)
        {
        }

        public void Update(Category entity)
        {
        }

        public void Delete(Category entity)
        {
        }
    }
}
