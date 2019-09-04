using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            string start;

            //じゃんけんゲームの参加人数を決める
            Input input = new Input();

            //ゲーム開始
            while (true)
            {
                Console.WriteLine("じゃんけんゲーム");
                Console.WriteLine("じゃんけんを始めます！");

                Judge judge = new Judge();

                for (int t = 0; t < input.time; t++)
                {
                    Console.WriteLine("{0}回戦目開始\n", t + 1);

                    judge.gamecount = 0;

                    while (judge.gamecount == 0)
                    {
                        //出す手の決定
                        input.Handmaker();

                        //勝敗の判定
                        judge.Gamejudge(input.personhand);
                        input.personhand.Clear();
                    }

                    Console.WriteLine("{0}回戦目終了\n", t + 1);

                }

                //最終結果の出力
                Result result = new Result();
                result.GameResult(input.sumnum, input.time, judge.winperson);

                while (true)
                {
                    Console.WriteLine("もう一度遊びますか？＞");

                    Console.WriteLine("もう一回 : Y");
                    Console.WriteLine("終了 　　: N");

                    start = Console.ReadLine();

                    if (start != "N" && start != "n" && start != "Y" && start != "y")
                    {
                        Console.WriteLine("入力が間違ってるよ");
                        continue;
                    }

                    break;
                }
      
                    if (start == "N" || start == "n")
                    {
                        break;
                    }
            }

            Console.WriteLine("また遊んでね");
            Console.ReadKey();
        }

    }

}
