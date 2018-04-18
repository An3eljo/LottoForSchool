using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class FillTicket
    {
        internal List<int> FilledNumbers;
        internal int extraNumber;
        public FillTicket()
        {
            FilledNumbers = new List<int>();
            extraNumber = 0;
        }

        internal void FillNumbers()
        {
            var looping = true;
            while (looping)
            {
                FilledNumbers.Clear();
                Console.Write("Your Numbers: ");
                var input = Console.ReadLine();
                Console.Write("Your extra number: ");
                int extraNumber = 0;
                if (!int.TryParse(Console.ReadLine(), out extraNumber))
                {
                    Console.WriteLine("Extra number has to be a number");
                }
                else
                {
                    if (extraNumber < 1 || extraNumber > 6)
                    {
                        Console.WriteLine("Extra number has to be between 1 and 6");
                    }
                    else
                    {
                        this.extraNumber = extraNumber;
                    }
                }
                
                var numbersStrings = input.Split(',');

                if (numbersStrings.Length != 6)
                {
                    Console.WriteLine("You have to choose 6 numbers");
                }

                for (int i = 0; i < 6; i++)
                {
                    FilledNumbers.Add(int.Parse(numbersStrings[i]));
                }
                for (int i = 0; i < FilledNumbers.Count; i++)
                {
                    if (FilledNumbers[i] < 1 || FilledNumbers[i] > 49)
                    {
                        Console.WriteLine("Numbers have to be between 1 and 49");
                        break;
                    }
                    for (int j = 0; j < FilledNumbers.Count; j++)
                    {
                        if (FilledNumbers[i] == FilledNumbers[j] && i != j)
                        {
                            looping = true;
                            Console.WriteLine("You can't choose a number twice");
                        }
                        else
                        {
                            looping = false;
                        }
                    }
                }
                /*foreach (var filledNumber in FilledNumbers)
                {
                    
                    if (filledNumber < 1 || filledNumber > 49)
                    {
                        Console.WriteLine("Numbers have to be between 1 and 49");
                        break;
                    }
                    foreach (var number in FilledNumbers)
                    {
                        if (number == filledNumber)
                        {
                            looping = true;
                            Console.WriteLine("You can't choose a number twice");
                        }
                    }
                }*/
            }
        }
    }
}
