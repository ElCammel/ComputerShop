using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping
{
    public class DeliveredStatus : OrderStatus
    {

        private List<Item> items;

        public DeliveredStatus(List<Item> items)
        {
            this.items = items;
        }

        public void AddItem(Item item)
        {
            throw new NotSupportedException();
        }

        public void RemoveItem(Item item)
        {
            throw new NotSupportedException();
        }
    }
}
