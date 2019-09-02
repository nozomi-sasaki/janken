using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Player
    {
        public void Sethand(Input In, out int usernum, out int sumnum)
        {
            //ユーザーの人数を決定する
            Console.WriteLine("何人で遊びますか＞");
            usernum = In.InPutnumber();

            //コンピューターの人数を決定する
            Console.WriteLine("コンピューターの人数を決めてください＞");
            int connum = In.InPutnumber();

            //合計の人数を計算する
            sumnum = usernum + connum;
            Console.WriteLine("ユーザー{0}人、コンピューター{1}人、合計{2}人でプレイします。\n", usernum, connum, sumnum);
        }

    }
}
