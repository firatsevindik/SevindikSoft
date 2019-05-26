using System;
using System.Collections.Generic;
using System.Text;
using Sevindik.Northwind.Business.Abstract;
using Sevindik.Northwind.DataAccess.Abstract;
using Sevindik.Northwind.Entities.Concrete;

namespace Sevindik.Northwind.Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
