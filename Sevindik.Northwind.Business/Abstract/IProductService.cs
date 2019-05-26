using System;
using System.Collections.Generic;
using System.Text;
using Sevindik.Northwind.Entities.Concrete;

namespace Sevindik.Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
        Product GetById(int productId);
    }
}
