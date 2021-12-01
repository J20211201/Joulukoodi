using System;
using System.Collections.Generic;
using System.Text;

namespace Joulukoodi
{
    public class Tehtavat
    {
        public int Tehtava1(int[] luvut)
        {
            int edellinenSyvyys = 0;
            int resultLarger = 0;

            for (int i = 0; i < luvut.Length; i++)
            {
                if (i>0)
                {
                    if (luvut[i]> edellinenSyvyys)
                    {
                        resultLarger++;
                    }
                }
                edellinenSyvyys = luvut[i];
            }

            return resultLarger;
        }
    }
}
