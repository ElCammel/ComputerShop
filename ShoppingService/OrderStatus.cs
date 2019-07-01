using System;
using System.Collections.Generic;
using System.Text;
using PcBuilder;

namespace ShoppingService
{
    public interface OrderStatus
    {
        List<IProduct> products { get; }

        void AddProduct(IProduct product);
        void RemoveProduct(IProduct product);
    }
}
