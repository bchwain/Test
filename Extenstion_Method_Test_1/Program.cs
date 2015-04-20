using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method_Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXAMPLE 1. //////////////////////////////////////////////////////////////////

            // Predefined .NET Int32 Structure assignment and instantiation
            int i = 57;

            // Int32.ToString() function already exists for us to use
            Console.WriteLine("i = " + i.ToString());

            // EXAMPLE 2. //////////////////////////////////////////////////////////////////

            // User defined object assignment and instantiation
            Money cash1 = new Money();

            // Set property
            cash1.Amount = 40M;

            // Must override Object.ToString() as this is a user defined type
            Console.WriteLine("cash1.ToString() returns: " + cash1.ToString());

            // Use of the extension method 'AddToAmount'
            cash1.AddToAmount(20M);

            // Must override Object.ToString() as this is a user defined type
            Console.WriteLine("cash1.ToString() returns: " + cash1.ToString());

            Console.ReadLine();

        }
    }

    public class Money
    {
        // Field
        private decimal amount;

        // Accessor
        public decimal Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }

        // Override of Object.ToString()
        public override string ToString()
        {
            return "$" + Amount.ToString();
        }
    }

    public static class MoneyExtension
    {
        public static void AddToAmount(this Money money, decimal amountToAdd)
        {
            money.Amount += amountToAdd;
        }

    }


}