using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    // A class to create objects for each Credit Card. 
    internal class CreditCard
    {
        // The number on card 
        public int CardNumber { get; set; }

        // The name on card
        public int CardHolderName { get; set; }

        // Card's experation month
        public int ExpMonth { get; set; }

        // Card's experation year
        public int ExpYear { get; set; }

        // The CVV on card
        public int CVV { get; set; }

    }
}
