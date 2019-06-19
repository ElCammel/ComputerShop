using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingService
{
    public class InprogressStatus : OrderStatus
    {

        private List<Item> items;

        public InprogressStatus(List<Item> items)
        {
            this.items = items;
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }

    }
}
