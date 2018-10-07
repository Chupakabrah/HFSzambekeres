using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamBekeresHF
{
    class MinMaxSzamok
    {
        public static int MaxSzam(int[] tomb)
        {
            int max = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (max < tomb[i])
                {
                    max = tomb[i];
                }
            }

            return max;
        }
    }
}
