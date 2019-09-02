using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Result
    {
        public void Gameresult(int sumnum, int time, List<int> person)
        {
            //結果出力
            int[] shouritsu = new int[sumnum];

            for (int i = 0; i < sumnum; i++)
            {
                shouritsu[i] = person.Count(value => value == i);

                Console.WriteLine("プレイヤー{0}の勝ち数は{1}、勝率は[2]", i, shouritsu[i], shouritsu[i] / time);
            }

            Console.WriteLine("\n");
        }
    }
}
