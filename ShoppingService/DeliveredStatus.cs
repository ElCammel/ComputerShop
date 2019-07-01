using System;
using System.Collections.Generic;
using System.Text;
using PcBuilder;

namespace ShoppingService
{
    public class DeliveredStatus : OrderStatus
    {

        public List<IProduct> products { get; }

        public DeliveredStatus()
        {
            this.products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            throw new NotSupportedException();
        }

        public void RemoveProduct(IProduct product)
        {
            throw new NotSupportedException();
        }
    }
}
