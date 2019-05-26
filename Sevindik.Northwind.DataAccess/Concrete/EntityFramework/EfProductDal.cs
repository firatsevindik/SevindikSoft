using System;
using System.Collections.Generic;
using System.Text;
using Sevindik.Core.DataAccess.EntityFramework;
using Sevindik.Northwind.DataAccess.Abstract;
using Sevindik.Northwind.Entities.Concrete;

namespace Sevindik.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {

    }
}
