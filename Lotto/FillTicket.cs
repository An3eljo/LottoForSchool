using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class FillTicket
    {
        internal List<int> FilledNumbers;
        public FillTicket()
        {
            Console.WriteLine("Your Numbers: ");
            var input = Console.ReadLine();
            var numbersStrings = input.Split(',');

            for (int i = 0; i < 6; i++)
            {
                FilledNumbers.Add(int.Parse(numbersStrings[i]));
            }
        }
    }
}
