using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Judge
    {
        public void Gamejudge(List<int> hand, List<int> person)
        {
            while (true)
            {
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
        }
    }
}


