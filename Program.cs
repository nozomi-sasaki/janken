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
            while (true)
            {
                Console.WriteLine("じゃんけんゲーム");
                Console.WriteLine("じゃんけんを始めますか？＞");

                Console.WriteLine("スタート : Y");
                Console.WriteLine("終了 　　: N");

                string start = Console.ReadLine();


                if (start == "Y" || start == "y")
                {

                    //じゃんけんゲーム開始

                    //ユーザーの人数を決定する
                    Console.WriteLine("何人で遊びますか＞");
                    int usernum = int.Parse(Console.ReadLine());

                    //コンピューターの人数を決定する
                    Console.WriteLine("コンピューターの人数を決めてください＞");
                   int connum = int.Parse(Console.ReadLine());

                    //合計の人数を計算する
                    int sumnum = usernum + connum;

                    Console.WriteLine("ユーザー{0}人、コンピューター{1}人、合計{2}人でプレイします。\n", usernum, connum, sumnum);


                    Console.WriteLine("何回勝負にしますか(あいこを除く)＞");
                    int time = int.Parse(Console.ReadLine());

                    Console.WriteLine("\n");

                    List<int> person = new List<int>();

                    //t;0～(time-1)(t+1回目のゲーム)
                    for (int t = 0; t < time; t++)
                    {
                        Console.WriteLine("{0}回戦目開始\n", t + 1);

                        while (true)
                        {
                            //出す手を決定する
                            List<int> hand = new List<int>();

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

                                    hand.Add(int.Parse(Console.ReadLine()));
                                    Console.WriteLine("\n");

                                    ////確認用
                                    //Console.WriteLine("{0}人目(ユーザー)の手は{1}です", i + 1, hand[i]);
                                }
                                else
                                {
                                    hand.Add(rnd.Next(3));
                                    ////確認用
                                    //Console.WriteLine("{0}人目(コンピューター)の手は{1}です", i + 1, hand[i]);
                                }

                            }


                            ////Console.WriteLine("List handの中身確認用");
                            //foreach (var a in hand)
                            //{
                            //    Console.WriteLine(a);
                            //}

                            //////結果判定
                            List<int> count = new List<int>();

                            //グーチョキパーのうち何種類の手があるか
                            //K:0,1,2(グーチョキパー)
                            for (int k = 0; k < 3; k++)
                            {

                                if (hand.Contains(k))
                                {
                                    count.Add(1);
                                }
                                else
                                {
                                    count.Add(0);
                                }
                                ////確認用
                                //Console.WriteLine("count[{0}]:{1}", i, count[k]);
                            }

                            //Console.WriteLine("List countの中身確認用");
                            //foreach (var b in count)
                            //{
                            //    Console.WriteLine(b);
                            //}

                            int countsum = count.Sum();

                            ////確認用
                            //Console.WriteLine("countsum:{0}", countsum);

                            //結果を表示させる
                            if (countsum == 1 || countsum == 3)
                            {
                                Console.WriteLine("あいこです\n");

                                continue;
                            }

                            else
                            {
                                if (count[0] == 0)
                                {
                                    Console.WriteLine("チョキの人の勝ちです\n");

                                    int person_cho = hand.IndexOf(1);
                                    //Console.WriteLine("{0}は{1}番目にあります", 1, person_cho + 1);

                                    person.Add(person_cho);

                                    while (person_cho >= 0)
                                    {
                                        //見つかった位置の次の位置から検索
                                        person_cho = hand.IndexOf(1, person_cho + 1);
                                        if (person_cho > 0)
                                        {
                                            person.Add(person_cho);
                                            //Console.WriteLine("{0}は{1}番目にあります", 1, person_cho + 1);

                                        }
                                    }


                                }

                                else if (count[1] == 0)
                                {
                                    Console.WriteLine("パーの人の勝ちです\n");

                                    int person_paa = hand.IndexOf(2);
                                    //Console.WriteLine("{0}は{1}番目にあります", 2, person_paa + 1);

                                    person.Add(person_paa);

                                    while (person_paa >= 0)
                                    {
                                        //見つかった位置の次の位置から検索
                                        person_paa = hand.IndexOf(2, person_paa + 1);
                                        if (person_paa > 0)
                                        {
                                            person.Add(person_paa);
                                            //Console.WriteLine("{0}は{1}番目にあります", 2, person_paa + 1);

                                        }
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("グーの人の勝ちです\n");

                                    int person_goo = hand.IndexOf(0);
                                    //Console.WriteLine("{0}は{1}番目にあります", 0, person_goo + 1);

                                    person.Add(person_goo);

                                    while (person_goo >= 0)
                                    {
                                        //見つかった位置の次の位置から検索
                                        person_goo = hand.IndexOf(0, person_goo + 1);
                                        if (person_goo > 0)
                                        {
                                            person.Add(person_goo);
                                            //Console.WriteLine("{0}は{1}番目にあります", 0, person_goo + 1);

                                        }

                                    }

                                }

                                //確認用
                                //foreach (var x in person)
                                //{
                                //    Console.WriteLine(x);
                                //}

                                break;
                            }

                        }

                        Console.WriteLine("{0}回戦目終了\n", t + 1);

                    }

                    //結果出力
                    int[] shouritsu = new int[sumnum];

                    for (int i = 0; i < sumnum; i++)
                    {
                        shouritsu[i] = person.Count(value => value == i);

                        Console.WriteLine("プレイヤー{0}の勝ち数は{1}", i, shouritsu[i]);
                    }

                    Console.WriteLine("\n");
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
            }

            Console.WriteLine("また遊んでね");
            Console.ReadLine();
        }
    }
}