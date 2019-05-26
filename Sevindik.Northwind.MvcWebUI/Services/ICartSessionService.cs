using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sevindik.Northwind.Entities.Concrete;

namespace Sevindik.Northwind.MvcWebUI.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}
