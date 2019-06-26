using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingService
{
    public class DeliveredStatus : OrderStatus
    {

        private List<PcBuilder.IProduct> products;

        public DeliveredStatus(List<PcBuilder.IProduct> products)
        {
            this.products = products;
        }

        public void AddProduct(PcBuilder.IProduct product)
        {
            throw new NotSupportedException();
        }

        public void RemoveProduct(PcBuilder.IProduct product)
        {
            throw new NotSupportedException();
        }
    }
}
