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
                //Get data from user
                FilledNumbers.Clear();
                Console.Write("Your Numbers: ");
                var input = Console.ReadLine();

                //Get extra number
                Console.Write("Your extra number: ");
                int extraNumber = 0;

                #region ErrorHandling

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

                #endregion

                //Converting Data from user
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
                    //ErrorHandling
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
            }
        }
    }
}
