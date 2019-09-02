using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Hand
    {
        public List<int> Personhand(int usernum, int sumnum, Input In)
        {
            ////出す手を決定する
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

                    //人間の手を入力させる
                    hand.Add(In.InPuthand());
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

            return hand;
        }
    }
}
