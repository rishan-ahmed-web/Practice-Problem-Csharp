using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class Cashpayment : IPayable
    {
        public void Pay(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be positive");
            Console.WriteLine($"Payment {amount} by cash");
        }
    }
}
