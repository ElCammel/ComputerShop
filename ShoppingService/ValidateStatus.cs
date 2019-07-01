using System;
using System.Collections.Generic;
using System.Text;
using PcBuilder;

namespace ShoppingService
{
    public class ValidateStatus : OrderStatus
    {

        public List<IProduct> products { get; }

        public ValidateStatus()
        {
            this.products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            throw new NotSupportedException();
        }

        public void RemoveProduct(IProduct product)
        {
            products.Remove(product);
        }
    }
}
