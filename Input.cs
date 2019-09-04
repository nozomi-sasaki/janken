using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Input
    {
        public int usernum;
        public int connum;
        public int sumnum;
        public int time;
        public List<int> personhand = new List<int>();

        public Input()
        {
            //ユーザーの人数を決定する
            Console.WriteLine("何人で遊びますか＞");
            usernum = CheckNumber();

            //コンピューターの人数を決定する
            Console.WriteLine("コンピューターの人数を決めてください＞");
            connum = CheckNumber();

            //合計の人数を計算する
            sumnum = usernum + connum;
            Console.WriteLine("ユーザー{0}人、コンピューター{1}人、合計{2}人でプレイします。\n", usernum, connum, sumnum);

            //じゃんけんゲームのプレイ回数を決める
            Console.WriteLine("何回勝負にしますか(あいこを除く)＞");
            time = CheckNumber();
            Console.WriteLine("\n");
        }

        public int CheckNumber()
        {
            while (true)
            {
                string input = Console.ReadLine();
                int number;

                if (int.TryParse(input, out number))
                {
                    if (int.Parse(input) < 0)
                    {
                        Console.WriteLine("0以上の整数を入力してね");
                        continue;
                    }

                    else if (int.Parse(input) < -2147483648 || int.Parse(input) > 2147483647)
                    {
                        Console.WriteLine("ちょっと多すぎます");
                        continue;
                    }

                    else if (input == null)
                    {
                        Console.WriteLine("入力してからenter押してね");
                        continue;
                    }

                    else
                    {
                        return number;
                    }
                }

                else
                {
                    Console.WriteLine("数字を入力してね");
                    continue;
                }

            }

        }

        public int CheckHand()
        {
            while (true)
            {
                string input = Console.ReadLine();
                int number;

                if (int.TryParse(input, out number))
                {
                    if (int.Parse(input) < 0 || int.Parse(input) > 2)
                    {
                        Console.WriteLine("0～2の整数を入力してね");
                        continue;
                    }

                    else if (input == null)
                    {
                        Console.WriteLine("入力してからenter押してね");
                        continue;
                    }

                    else
                    {
                        return number;
                    }
                }

                else
                {
                    Console.WriteLine("数字を入力してね");
                    continue;
                }

            }

        }

        public List<int> Handmaker()
        {
            ////出す手を決定する
            Random rnd = new Random();

            //i:0～(sumnum-1)(i+1番目のプレイヤー)
            for (int i = 0; i < sumnum; i++)
            {
                if (i < usernum)
                {
                    Console.WriteLine("{0}人目の出す手の番号を入力してください＞", i + 1);
                    Console.WriteLine("0 : グー");
                    Console.WriteLine("1 : チョキ");
                    Console.WriteLine("2 : パー");

                    //人間の手を入力させる
                    personhand.Add(CheckHand());
                    Console.WriteLine("\n");

                    ////確認用
                    Console.WriteLine("{0}人目(ユーザー)の手は{1}です", i + 1, personhand[i]);
                }
                else
                {
                    personhand.Add(rnd.Next(3));
                    ////確認用
                    Console.WriteLine("{0}人目(コンピューター)の手は{1}です", i + 1, personhand[i]);
                }

            }
            return personhand;
        }
    }
}
