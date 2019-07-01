using System;
using System.Collections.Generic;
using System.Text;
using PcBuilder;

namespace ShoppingService
{
    public interface OrderStatus
    {
        void AddProduct(IProduct product);
        void RemoveProduct(IProduct product);
    }
}
