using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Uzduotis17_Kodas
{
    public class LyginiaiSkaiciai
    {
        static public int Lyginiai()
        {
            int[] skaiciai = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int lyginis = 0;
            foreach (int i in skaiciai)
            {
                if (i % 2 == 0)
                    lyginis++;
            }
            return lyginis;
        }
    }
}
