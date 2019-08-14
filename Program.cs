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
            //
            Console.WriteLine("じゃんけんゲーム");
            Console.WriteLine("じゃんけんを始めますか？＞");

            Console.WriteLine("スタート : Y");
            Console.WriteLine("終了 　　: N");

            string start = Console.ReadLine();

            if (start == "Y" || start == "y")
            {
                //じゃんけんゲーム開始
                hand();
                Console.WriteLine("もう一度挑戦しますか？＞");
            }
            else
            {
                Console.WriteLine("じゃんけんを終了します");
            }
        }

        //ユーザーの出す手を決めるメソッド
        static void hand()
        {
            Console.WriteLine("出す手の番号を入力してください＞");
            Console.WriteLine("0 : グー");
            Console.WriteLine("1 : チョキ");
            Console.WriteLine("2 : パー");

            string userhand = Console.ReadLine();
            Console.WriteLine(userhand);

            game(userhand);
        }

        //じゃんけんの勝敗を決めるメソッド
        static void game(string user)
        {
            Random rnd = new System.Random();
            string con = rnd.Next(3).ToString();

            Console.WriteLine(con);

            //コンピュータが勝利した場合
            if (((user == "0") && (con == "2")) ||　((user == "1") && (con == "0")) ||　((user == "2") && (con == "1")))
            {
                Console.WriteLine("コンピュータの勝ちです\n");
            }
            //自分が勝利した場合
            else if (((user == "0") && (con == "1")) || ((user == "1") && (con == "2")) || ((user == "2") && (con == "0")))
            {
                Console.WriteLine("あなたの勝ちです\n");
            }
            //あいこだった場合
            else
            {
                Console.WriteLine("あいこです");
                Console.WriteLine("もう一度じゃんけんを始めます\n");

                //もう一度ユーザーの出す手を決めるメソッドを呼び出す
                hand();
            }

        }
    }
}

