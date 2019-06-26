using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingService
{
    public class InprogressStatus : OrderStatus
    {

        private List<PcBuilder.IProduct> items;

        public InprogressStatus(List<PcBuilder.IProduct> items)
        {
            this.items = items;
        }

        public void AddProduct(PcBuilder.IProduct item)
        {
            items.Add(item);
        }

        public void RemoveProduct(PcBuilder.IProduct item)
        {
            items.Remove(item);
        }

    }
}
