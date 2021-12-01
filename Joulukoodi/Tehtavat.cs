using System;
using System.Collections.Generic;
using System.Text;

namespace Joulukoodi
{
    public class Tehtavat
    {
        public List<string> Tehtava1(int[] luvut)
        {
            int edellinenSyvyys = 0;
            string arvo = "";
            List<string> tulos = new List<string>();

            for (int i = 0; i < luvut.Length; i++)
            {
                if (i == 0)
                {
                    arvo = luvut[i] + " (N/A - no previous measurement)";
                    tulos.Add(arvo);
                    
                }
                else
                {
                    if (edellinenSyvyys < luvut[i])
                    {
                        arvo = luvut[i] + " (increased)";
                        tulos.Add(arvo);
                    }
                    else
                    {
                        arvo = luvut[i] + " (decreased)";
                        tulos.Add(arvo);
                    }
                }
                edellinenSyvyys = luvut[i];
            }

            return tulos;
        }
    }
}
