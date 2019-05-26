using Sevindik.Core.DataAccess.EntityFramework;
using Sevindik.Northwind.DataAccess.Abstract;
using Sevindik.Northwind.Entities.Concrete;

namespace Sevindik.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {

    }
}