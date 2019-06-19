using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingService
{
    public class ValidateStatus : OrderStatus
    {

        private List<Item> items;

        public ValidateStatus(List<Item> items)
        {
            this.items = items;
        }

        public void AddItem(Item item)
        {
            throw new NotSupportedException();
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }
    }
}
