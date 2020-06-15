using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace IceCreamShop
{
    public class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            int num = 0;

            if (x.Cost - y.Cost < 0){ num = -1; }
            if (y.Cost - x.Cost < 0) { num = 1; }

            return num;
        }
    }
}
