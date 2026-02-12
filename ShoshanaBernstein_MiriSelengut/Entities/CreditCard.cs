using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Entities
{
    // A class to create objects for each Credit Card. 
    public class CreditCard
    {
        // The number on card 
        public string CardNumber { get; set; }

        // The name on card
        public string CardHolderName { get; set; }

        // Card's experation month
        public string ExpMonth { get; set; }

        // Card's experation year
        public string ExpYear { get; set; }

        // The CVV on card
        public string CVV { get; set; }

        public CreditCard(string CardHolderName, string CardNumber, string ExpMonth, string ExpYear, string CVV)
        {
            this.CardHolderName = CardHolderName;
            this.CardNumber = CardNumber;
            this.ExpMonth = ExpMonth;
            this.ExpYear = ExpYear;
            this.CVV = CVV;
        }

        public override string ToString()
        {
            return "\nName on card: " + CardHolderName + "\nCard number: " + CardNumber + "\nExperation month: " + ExpMonth + "\nExperation Year: " + ExpYear + "\nCVV: " + CVV;
        }

    }
}
