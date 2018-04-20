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
            #region Initialize

            var winningNumbers = new List<int>();
            var draw = new Drawing();
            var ticket = new FillTicket();

            #endregion

            
            draw.DrawNumbers();
            ticket.FillNumbers();

            //Get winning numbers
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

            //Evaluate output
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

            //Evaluate if extra number is correct
            if (draw.ExtraNumber == ticket.extraNumber)
            {
                Console.WriteLine("Your extra number" + draw.ExtraNumber + "is correct!");
            }

            Console.ReadKey();
        }
    }
}
