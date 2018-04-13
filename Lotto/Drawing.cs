using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Drawing
    {
        internal List<int> DrawedNumbers;
        public Drawing()
        {
            DrawedNumbers = new List<int>();
            
        }

        internal void DrawNumbers()
        {
            var random = new Random();
            for (int i = 0; i < 6; i++)
            {
                DrawedNumbers.Add(GetRandom(random, DrawedNumbers));
            }
        }

        private static int GetRandom(Random random, List<int> randomList)
        {
            var r = random.Next(1, 49 + 1);
            foreach (var i in randomList)
            {
                if (i == r)
                {
                    r = GetRandom(random, randomList);
                }
            }

            return r;
        }
    }
}
