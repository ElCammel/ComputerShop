using System;
using System.Collections.Generic;
using System.Text;
using PcBuilder;
namespace ShoppingService
{
    public class ValidateStatus : OrderStatus
    {

        private List<IProduct> products;

        public ValidateStatus(List<IProduct> products)
        {
            this.products = products;
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
