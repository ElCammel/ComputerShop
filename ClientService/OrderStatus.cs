using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping
{
    public interface OrderStatus
    {
        void AddItem(Item item);
        void RemoveItem(Item item);
    }
}
