using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            var winningNumbers = new List<int>();
            var draw = new Drawing();
            var ticket = new FillTicket();

            draw.DrawNumbers();
            ticket.FillNumbers();
            ticket.FilledNumbers[2] = draw.DrawedNumbers[4];
            ticket.FilledNumbers[5] = draw.DrawedNumbers[2];

            foreach (var ticketFilledNumber in ticket.FilledNumbers)
            {
                foreach (var drawDrawedNumber in draw.DrawedNumbers)
                {
                    if (drawDrawedNumber == ticketFilledNumber)
                    {
                        winningNumbers.Add(drawDrawedNumber);
                    }
                }
            }

            if (winningNumbers.Count == 0)
            {
                Console.WriteLine("Sorry, but you didn't win anything");
            }
            else
            {
                Console.WriteLine("Your winning Numbers");
                foreach (var winningNumber in winningNumbers)
                {
                    Console.WriteLine(winningNumber);
                }
            }
        }
    }
}
