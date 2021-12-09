using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Joulukoodi
{
    class Program
    {
        static void Main(string[] args)
        {
            Tehtavat tehtavat = new Tehtavat();
            int[] teht1 = { 157,158};

            string[] teht2 = {"forward 4"
,"down 9"};

            


            string[] teht3b = {"00100"
,"11110"
,"10110"
,"10111"
,"10101"
,"01111"
,"00111"
,"11100"
,"10000"
,"11001"
,"00010"
,"01010"};

            


            /*
            int indx = 0;
            int varIndx = 1;
            FileStream fsOut = File.Create(@"C:\dev\temp\joulukoodi\teht4\newbingo.txt");
            FileStream fsIn = File.OpenRead(@"C:\dev\temp\joulukoodi\teht4\bingo.txt");
            StreamReader sr = new StreamReader(fsIn);
            StreamWriter sw = new StreamWriter(fsOut);
            while (!sr.EndOfStream)
            {
                string inputLine = sr.ReadLine();

                if (inputLine.Length > 0)
                {
                    inputLine = inputLine.TrimStart();

                    string[] subs = inputLine.Split(' ');

                    string tempLine = "";
                    for (int i = 0; i < subs.Length; i++)
                    {
                        if(subs[i] != "")
                        {
                            if ((i + 1) < subs.Length)
                            {
                                tempLine += subs[i] + ",";
                            }
                            else
                            {
                                tempLine += subs[i];
                            }
                        }
                        
                    }

                    inputLine = tempLine;

                    if (indx == 0)
                    {
                        inputLine = "int[,] teht4_bingocard"+varIndx+" = {{";
                    }
                    else
                    {
                        inputLine = "{";
                    }
                    
                    inputLine += tempLine;

                    if (indx == 4)
                    {
                        inputLine += "}};";
                    }
                    else
                    {
                        inputLine += "},";
                    }

                    inputLine = inputLine + "\n";
                    indx = indx + 1;
                }
                else
                {
                    varIndx = varIndx + 1;
                    indx = 0;
                    inputLine = "\n";
                }
                
                sw.Write(inputLine);
            }
            sw.Flush();
            fsOut.Close();
            
            FileStream fsOut2 = File.Create(@"C:\dev\temp\joulukoodi\teht4\newbingo_bcard.txt");

            StreamWriter sw2 = new StreamWriter(fsOut2);

            for (int i = 1; i < 101; i++)
            {
                string inputLine = "BingoCard bcard" + i + " = new BingoCard();";
                inputLine += "\n";
                inputLine += "bcard" + i + ".card = teht4_bingocard"+i+";";
                inputLine += "\n";
                inputLine += "bcard" + i + ".bingo = 0;";
                inputLine += "\n";
                inputLine += "lstbcard.Add(bcard" + i + ");";
                inputLine += "\n";
                inputLine += "\n";
                sw2.Write(inputLine);
            }
            sw2.Flush();
            fsOut2.Close();
            */

            List<BingoCard> lstbcard = new List<BingoCard>();

            int[,] teht4_bingocard1 = {{50,98,65,14,47},
{0,22,3,83,46},
{87,93,81,84,58},
{40,35,28,74,48},
{45,99,59,37,64}};

            

            BingoCard bcard1 = new BingoCard();
            bcard1.card = teht4_bingocard1;
            bcard1.bingo = 0;
            lstbcard.Add(bcard1);


            int[] numbers = { 23, 30, 70, 61, 79, 49, 19, 37, 64, 48, 72, 34, 69, 53, 15, 74, 89, 38, 46, 36, 28, 32, 45, 2, 39, 58, 11, 62, 97, 40, 14, 87, 96, 94, 91, 92, 80, 99, 6, 31, 57, 98, 65, 10, 33, 63, 42, 17, 47, 66, 26, 22, 73, 27, 7, 0, 55, 8, 56, 29, 86, 25, 4, 12, 51, 60, 35, 50, 5, 75, 95, 44, 16, 93, 21, 3, 24, 52, 77, 76, 43, 41, 9, 84, 67, 71, 83, 88, 59, 68, 85, 82 };


            //var tulos = tehtavat.Tehtava1(teht1);
            //var tulos1b = tehtavat.Tehtava1b(teht1);
            //var tulos2 = tehtavat.Tehtava2(teht2);
            //var tulos2b = tehtavat.Tehtava2b(teht2);
            //var tulos3 = tehtavat.Tehtava3(teht3,12);
            //var tulos3 = tehtavat.Tehtava3b(teht3, 12);
            var tulos4 = tehtavat.Teht4(lstbcard, numbers);

            var test1 = Convert.ToInt32("000011001101", 2);
            var test2 = Convert.ToInt32("000011001111", 2);
            var test3 = Convert.ToInt32("001011001101", 2);
            var test5 = Convert.ToInt32("101101010110", 2);
            var test6 = Convert.ToInt32("101101011111", 2);

            Console.WriteLine("Hello World!");
        }
    }
}
