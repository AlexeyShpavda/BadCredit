using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCredit
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter car name -->");
            string cardNumber = Console.ReadLine();

            Console.WriteLine("your card is " + Card.ReturnsCardName(cardNumber));
            Console.ReadKey();
        }
    }
}
