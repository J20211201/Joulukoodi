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

        public int Tehtava1b(int[] luvut)
        {
            int edellinenSyvyys = 0;
            int syvyys = 0;
            int resultLarger = 0;
            int index2 = 0;
            int index3 = 0;
            List<int> lstLuvut = new List<int>();

            for (int i = 0; i < luvut.Length; i++)
            {
                if (i < 1998)
                {
                    index2 = i + 1;
                    index3 = i + 2;
                    syvyys = luvut[i] + luvut[index2] + luvut[index3];

                    lstLuvut.Add(syvyys);
                }
            }

            for (int i = 0; i < lstLuvut.Count; i++)
            {
                if (i > 0)
                { 
                    if(lstLuvut[i]>edellinenSyvyys)
                    {
                        resultLarger++;
                    }
                }
                edellinenSyvyys = lstLuvut[i];
            }

            return resultLarger;
        }
    }
}
