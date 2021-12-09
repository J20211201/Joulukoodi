using System;
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

            for (int i = 0; i < textlenght; i++)
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

        public int Tehtava3b(string[] luvut, int textlenght)
        {
            int result = 0;
            int msgzero = 0;
            int msgone = 0;
            int index = 0;

            List<string> lstLuvut = new List<string>();

            for(int i = 0; i < luvut.Length; i++)
            {
                lstLuvut.Add(luvut[i]);
            }

            List<string> lstLuvutb = new List<string>();

            for (int i = 0; i < luvut.Length; i++)
            {
                lstLuvutb.Add(luvut[i]);
            }

            for (int i = 0; i < textlenght; i++)
            {
                index = i;
                
                msgzero = lstLuvut.Where(l => l.Substring(index, 1) == "0").Count();
                msgone = lstLuvut.Where(l => l.Substring(index, 1) == "1").Count();

                if (msgone> msgzero && (msgzero > 0 && msgone > 0))
                {
                    lstLuvut.RemoveAll(x => x.Substring(index, 1) == "0");
                }
                else if (msgzero> msgone && (msgzero > 0 && msgone > 0))
                {
                    lstLuvut.RemoveAll(x => x.Substring(index, 1) == "1");
                }

                if (i==(textlenght-1))
                {
                    var luvutLsta = lstLuvut;
                }
            }

            for (int i = 0; i < textlenght; i++)
            {
                index = i;

                msgzero = lstLuvutb.Where(l => l.Substring(index, 1) == "0").Count();
                msgone = lstLuvutb.Where(l => l.Substring(index, 1) == "1").Count();

                if (msgone < msgzero && (msgzero>0&& msgone>0))
                {
                    lstLuvutb.RemoveAll(x => x.Substring(index, 1) == "0");
                }
                else if (msgzero < msgone && (msgzero > 0 && msgone > 0))
                {
                    lstLuvutb.RemoveAll(x => x.Substring(index, 1) == "1");
                }

                if (i == (textlenght - 1))
                {
                    var luvutLstb = lstLuvutb;
                }
            }

            return result;
        }

        public int Teht4(List<BingoCard> lstbcard, int[] numbers)
        {
            int result = 0;

            List<BingoCardScore> lstBingoCardScore = new List<BingoCardScore>();


            foreach (var bcard in lstbcard)
            {
                result = result + 1;
                BingoCardScore score = new BingoCardScore();
                score = CheckForLine(bcard.card,numbers, result);

                if(score.bingo==1)
                {
                    lstBingoCardScore.Add(score);
                }
                else
                {
                    int huti = score.cardNro;
                }
            }

            

            return result;
        }

        static BingoCardScore CheckForLine(int[,] bingoCard, int[] numbers,int cardnro)
        {
            BingoCardScore bscore = new BingoCardScore();
            bscore.bingo = 0;
            bscore.cardNro = cardnro;
            List<int> tulos = new List<int>();
            int lukuBingo = 0;

            for (int row = 0; row < bingoCard.GetLength(0); row++)
            {
                // For a 'line', we only need to match all columns in a row, 
                // so create a counter to track that here
                int colMatchesInRow = 0;

                for (int col = 0; col < bingoCard.GetLength(1); col++)
                {
                    for (int numIndex = 0; numIndex < numbers.Length; numIndex++)
                    {
                        if (bingoCard[row, col] == numbers[numIndex])
                        {
                            lukuBingo = bingoCard[row, col];
                            if (bscore.bingo == 0)
                            {
                                tulos.Add(bingoCard[row, col]);
                            }
                            // Match found! Increment our counter and break from this loop                           
                            colMatchesInRow++;
                            break;
                        }
                    }
                }

                // If our counter equals the number of columns, return 'true'
                if (colMatchesInRow == bingoCard.GetLength(1))
                {
                    bscore.bingo = 1;
                    bscore.tulos = tulos;
                }
            }

            // If we get this far, we never found a 'line', so return 'false'
            return bscore;
        }
    }
}
