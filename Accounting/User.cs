using System;
using System.Collections.Generic;

namespace Accounting
{
    public class User
    {
        public Address shippingAddress { get; set; }
        public Address billingAddress { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public int phoneNumber { get; set; }
        public List<CreditCard> cards { get; set; }

        public User(Address shippingAddress, Address billingAddress, string name, string lastName, string email)
        {
            this.shippingAddress = shippingAddress;
            this.billingAddress = billingAddress;
            this.name = name;
            this.lastName = lastName;
            this.email = email;
            
        }

        public User(Address shippingAddress, Address billingAddress, string name, string lastName, int phoneNumber)
        {
            this.shippingAddress = shippingAddress;
            this.billingAddress = billingAddress;
            this.name = name;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
        }
        
        public bool AddCard(CreditCard card)
        {
            if (card.IsValidCardInfos())
            {
                this.cards.Add(card);
                return true;
            }

            return false;
        }
    }
}