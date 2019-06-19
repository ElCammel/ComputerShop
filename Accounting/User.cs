using System;
using System.Collections.Generic;

namespace Accounting
{
    public class Client
    {
        public List<Address> addresses { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public int phoneNumber { get; set; }
        public List<CreditCard> cards { get; set; }

        public Client(Address address, string name, string lastName, string email)
        {
            this.addresses.Add(address);
            this.name = name;
            this.lastName = lastName;
            this.email = email;
        }

        public Client(Address address, string name, string lastName, int phoneNumber)
        {
            this.addresses.Add(address);
            this.name = name;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
        }

        public void AddAdress(Address address)
        {
            this.addresses.Add(address);
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