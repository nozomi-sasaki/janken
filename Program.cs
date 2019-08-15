using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Janken
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("じゃんけんゲーム");
            Console.WriteLine("じゃんけんを始めますか？＞");

            Console.WriteLine("スタート : Y");
            Console.WriteLine("終了 　　: N");

            string start = Console.ReadLine();

            if (start == "Y" || start == "y")
            {
                //じゃんけんゲーム開始


                //////ユーザー・コンピューターの人数を設定する

                //ユーザーの人数を決定する
                Console.WriteLine("参加するプレイヤーの人数を入力してください＞");
                int usernum = int.Parse(Console.ReadLine());

                //コンピューターの人数を決定する
                Console.WriteLine("コンピューターの人数を決めてください＞");
                int connum = int.Parse(Console.ReadLine());

                //合計の人数を計算する
                int sumnum = usernum + connum;

                Console.WriteLine("ユーザー{0}人、コンピューター{1}人、合計{2}人でプレイします。\n", usernum, connum, sumnum);

                //出す手を決定する
                int[] hand = new int[sumnum];

                Random rnd = new Random();

                for (int i = 0; i < sumnum; i++)
                {
                    if (i < usernum)
                    {
                        Console.WriteLine("{0}人目の出す手の番号を入力してください＞", i + 1);
                        Console.WriteLine("0 : グー");
                        Console.WriteLine("1 : チョキ");
                        Console.WriteLine("2 : パー");

                        hand[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine(hand[i]);
                    }
                    else
                    {
                        hand[i] = rnd.Next(3);
                        //確認用
                        //    Console.WriteLine("{0}人目(コンピューター)の手は{1}です", i + 1, hand[i]);
                    }
                }


                //////結果判定



                //count[]の初期化
                int[] count = new int[] { 0, 0, 0 };

                //グーチョキパーのうち何種類の手があるか
                for (int i = 0; i < 3; i++)
                    {
                        if (((IList<int>)hand).Contains(i))
                        {
                            count[i] = 1;
                        }
                    }

                int countsum = count.Sum();

                    Console.WriteLine("countsum:{0}",countsum);


                //結果を表示させる
                if (countsum == 1 || countsum == 3)
                    {
                        Console.WriteLine("あいこです");

                    //出す手を決定するメソッドを呼び出す
                }

                else
                    {

                    if (count[0] == 0)
                        {
                            Console.WriteLine("チョキの人の勝ちです");
                        }
                    else if (count[1] == 0)
                        {
                            Console.WriteLine("パーの人の勝ちです");
                        }
                    else
                        {
                            Console.WriteLine("グーの人の勝ちです");
                        }
                    }

                Console.WriteLine("もう一度挑戦しますか？＞");

                Console.WriteLine("続行 : Y");
                Console.WriteLine("終了 : N");

                Console.ReadLine();
            }

        }
    }
}