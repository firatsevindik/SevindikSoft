using System.Collections.Generic;
using Sevindik.Northwind.Entities.Concrete;

namespace Sevindik.Northwind.MvcWebUI.Models
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}