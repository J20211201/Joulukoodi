﻿using System;
using System.Collections.Generic;
using System.Linq;
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
                if (i > 0)
                {
                    if (luvut[i] > edellinenSyvyys)
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
                    if (lstLuvut[i] > edellinenSyvyys)
                    {
                        resultLarger++;
                    }
                }
                edellinenSyvyys = lstLuvut[i];
            }

            return resultLarger;
        }


        public int Tehtava2(string[] luvut)
        {
            int result = 0;
            int horizontal_pos = 0;
            int depth = 0;

            for (int i = 0; i < luvut.Length; i++)
            {
                string[] splitattu = luvut[i].Split(' ');

                if (splitattu[0]== "forward")
                {
                    horizontal_pos += Int32.Parse(splitattu[1].Trim());
                }
                else if (splitattu[0] == "down")
                {
                    depth += Int32.Parse(splitattu[1].Trim());
                }
                else if (splitattu[0] == "up")
                {
                    depth -= Int32.Parse(splitattu[1].Trim());
                }
            }

            result = horizontal_pos * depth;

            return result;
        }

        public int Tehtava2b(string[] luvut)
        {
            int result = 0;
            int horizontal_pos = 0;
            int depth = 0;
            int aim = 0;

            for (int i = 0; i < luvut.Length; i++)
            {
                string[] splitattu = luvut[i].Split(' ');

                if (splitattu[0] == "forward")
                {
                    depth += aim * Int32.Parse(splitattu[1].Trim());
                    horizontal_pos += Int32.Parse(splitattu[1].Trim());
                }
                else if (splitattu[0] == "down")
                {
                    aim += Int32.Parse(splitattu[1].Trim());
                }
                else if (splitattu[0] == "up")
                {
                    aim -= Int32.Parse(splitattu[1].Trim());
                }
            }

            result = horizontal_pos * depth;

            return result;
        }

        public int Tehtava3(string[] luvut,int textlenght)
        {
            int result = 0;
            int gamma = 0;
            int epsilon = 0;
            int index = 0;
            string mostcommon = "";
            string leastcommon = "";

            for(int i = 0; i < textlenght; i++)
            {
                index = i;
                mostcommon += luvut
                .GroupBy(i => i.Substring(index, 1))
                .OrderByDescending(g => g.Count())
                .Take(1)
                .Select(g => g.Key).First().ToString();
            }

            for (int i = 0; i < textlenght; i++)
            {
                index = i;
                leastcommon += luvut
                .GroupBy(i => i.Substring(index, 1))
                .OrderBy(g => g.Count())
                .Take(1)
                .Select(g => g.Key).First().ToString();
            }

            gamma = Convert.ToInt32(mostcommon, 2);
            epsilon = Convert.ToInt32(leastcommon, 2);

            result = gamma * epsilon;

            return result;
        }
    }
}
