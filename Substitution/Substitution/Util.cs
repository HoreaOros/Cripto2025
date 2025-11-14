using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substitution
{
    internal class Util
    {
        public static void Shuffle(int[] v)
        {
            Random random = new Random();
            int j;
            for(int i = v.Length - 1; i > 0; i--)
            {
                j = random.Next(i + 1 );
                (v[i], v[j]) = (v[j], v[i]);
            }
        }
    }
}

