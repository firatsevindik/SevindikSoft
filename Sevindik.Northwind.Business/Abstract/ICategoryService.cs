using System.Collections.Generic;
using Sevindik.Northwind.Entities.Concrete;

namespace Sevindik.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}