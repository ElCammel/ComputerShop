using System;
using System.Collections.Generic;
using System.Text;
using PcBuilder;

namespace ShoppingService
{
    public class InprogressStatus : OrderStatus
    {

        public List<IProduct> products { get; }

        public InprogressStatus()
        {
            this.products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            products.Remove(product);
        }

    }
}
