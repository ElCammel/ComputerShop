using System;
using System.Collections.Generic;
using System.Text;
using PcBuilder;

namespace ShoppingService
{
    public class DeliveredStatus : OrderStatus
    {

        private List<IProduct> products;

        public DeliveredStatus(List<IProduct> products)
        {
            this.products = products;
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
