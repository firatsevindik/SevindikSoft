using System.Collections.Generic;
using Sevindik.Northwind.Entities.Concrete;

namespace Sevindik.Northwind.MvcWebUI.Models
{
    public class ProductAddViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}