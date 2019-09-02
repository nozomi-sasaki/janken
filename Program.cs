using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int usernum, sumnum;

            //じゃんけんゲームの参加人数を決める
            Player Play = new Player();
            Input In = new Input();
            Play.Sethand(In, out usernum, out sumnum);

            //じゃんけんゲームのプレイ回数を決める
            Console.WriteLine("何回勝負にしますか(あいこを除く)＞");
            int time = In.InPutnumber();
            Console.WriteLine("\n");

            //ゲーム開始
            while (true)
            {
                Console.WriteLine("じゃんけんゲーム");
                Console.WriteLine("じゃんけんを始めます！");

                //1週目のみ初期値"Y"に設定しておく
                string start = "Y";

                if (start == "Y" || start == "y")
                {
                    Hand Ha = new Hand();
                    List<int> hand = Ha.Personhand(usernum, sumnum, In);

                    List<int> person = new List<int>();

                    for (int t = 0; t < time; t++)
                    {
                        Console.WriteLine("{0}回戦目開始\n", t + 1);

                        //勝敗の判定
                        Judge Ju = new Judge();
                        Ju.Gamejudge(hand, person);

                        Console.WriteLine("{0}回戦目終了\n", t + 1);

                    }

                    //最終結果の出力
                    Result Re = new Result();
                    Re.Gameresult(sumnum, time, person);

                }

                else if (start == "N" || start == "n")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("入力が間違ってるよ");
                    continue;
                }

                Console.WriteLine("もう一度遊びますか？＞");

                Console.WriteLine("もう一回 : Y");
                Console.WriteLine("終了 　　: N");

                start.Replace("Y", Console.ReadLine());

            }

            Console.WriteLine("また遊んでね");
            Console.ReadKey();
        }

    }
}
