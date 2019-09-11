using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Result
    {
        public void GameResult(int sumnum, int time, List<int> winperson)
        {
            //結果出力
            int[] winnum = new int[sumnum];

            Encoding enc = Encoding.GetEncoding("Shift_JIS");
            string filepath = Path.Combine(@"C:\Users\nozomi.sasaki\source\repos\UnitTestJanken\bin\Debug\Output.txt");


            for (int i = 0; i < sumnum; i++)
            {
                winnum[i] = winperson.Count(value => value == i);
                double shouritsu = 1.0 * winnum[i] / time;

                Console.WriteLine("プレイヤー{0}の勝ち数は{1}、勝率は{2:f2}", i, winnum[i], shouritsu);

                StreamWriter file = new StreamWriter(filepath, true, enc);
                file.WriteLine("プレイヤー{0}の勝ち数は{1}、勝率は{2:f2}", i, winnum[i], shouritsu);

                file.Close();
            }

            Console.WriteLine("\n");
        }
    }
}
