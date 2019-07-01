using System;
using System.Collections.Generic;
using System.Text;
using PcBuilder;

namespace ShoppingService
{
    public class InprogressStatus : OrderStatus
    {

        private List<IProduct> items;

        public InprogressStatus(List<IProduct> items)
        {
            this.items = items;
        }

        public void AddProduct(IProduct item)
        {
            items.Add(item);
        }

        public void RemoveProduct(IProduct item)
        {
            items.Remove(item);
        }

    }
}
