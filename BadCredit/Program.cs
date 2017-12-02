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
            Console.Write("Enter car name -->");
            string cardNumber = Console.ReadLine();

            Card card = new Card(cardNumber);

            Console.WriteLine(card.ReturnsCardName());
            Console.ReadKey();
        }
    }
}
