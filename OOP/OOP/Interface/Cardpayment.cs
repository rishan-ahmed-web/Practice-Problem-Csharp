using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class Cardpayment : IPayable
    {
        public void Pay(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be positive");
            Console.WriteLine($"payment {amount} by card");
        }
    }
}
