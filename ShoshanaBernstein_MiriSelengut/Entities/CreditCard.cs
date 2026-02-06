using System;
using System.Collections.Generic;
using System.Text;

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

    }
}
