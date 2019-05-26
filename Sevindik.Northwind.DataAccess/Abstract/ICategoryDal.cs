using System;
using System.Collections.Generic;
using System.Text;
using Sevindik.Core.DataAccess;
using Sevindik.Northwind.Entities.Concrete;

namespace Sevindik.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal: IEntityRepository<Category>
    {
        //Custom Operations
    }
}
