using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ClientService
{
    public class CreditCard
    {

        public string cardNumber { get; set; }
        public string cvvCode { get; set; }
        public string expirationDate { get; set; }

        public CreditCard(string cardNumber, string cvvCode, string expirationDate)
        {
            this.cardNumber = cardNumber;
            this.cvvCode = cvvCode;
            this.expirationDate = expirationDate;
        }

        public bool IsValidCardInfos()
        {
            return IsDateExpired() && IsValidSecurityCode() && IsValidCardNumber();
        }

        public bool IsDateExpired()
        {
            var monthCheck = new Regex(@"^(0[1-9]|1[0-2])$");
            var yearCheck = new Regex(@"^20[0-9]{2}$");
            var dateParts = expirationDate.Split('/');

            if (!monthCheck.IsMatch(dateParts[0]) || !yearCheck.IsMatch(dateParts[1]))
            {
                return false;
            }

            var year = int.Parse(dateParts[1]);
            var month = int.Parse(dateParts[0]);
            var lastDateOfExpiryMonth = DateTime.DaysInMonth(year, month);
            var cardExpiry = new DateTime(year, month, lastDateOfExpiryMonth, 23, 59, 59);
            
            return (cardExpiry > DateTime.Now && cardExpiry < DateTime.Now.AddYears(6));
        }

        public bool IsValidSecurityCode()
        {
            var cvvCheck = new Regex(@"^\d{3}$");
            return cvvCheck.IsMatch(cvvCode);
        }

        public bool IsValidCardNumber()
        {
            var cardCheck = new Regex(@"^(1298|1267|4512|4567|8901|8933)([\-\s]?[0-9]{4}){3}$");
            return cardCheck.IsMatch(this.cardNumber);
        }
    }
}
