using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingService
{
    public interface OrderStatus
    {
        void AddProduct(PcBuilder.IProduct product);
        void RemoveProduct(PcBuilder.IProduct product);
    }
}
