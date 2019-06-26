using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingService
{
    public class ValidateStatus : OrderStatus
    {

        private List<PcBuilder.IProduct> products;

        public ValidateStatus(List<PcBuilder.IProduct> products)
        {
            this.products = products;
        }

        public void AddProduct(PcBuilder.IProduct product)
        {
            throw new NotSupportedException();
        }

        public void RemoveProduct(PcBuilder.IProduct product)
        {
            products.Remove(product);
        }
    }
}
