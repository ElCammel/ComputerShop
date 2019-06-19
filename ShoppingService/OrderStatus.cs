using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingService
{
    public interface OrderStatus
    {
        void AddItem(Item item);
        void RemoveItem(Item item);
    }
}
