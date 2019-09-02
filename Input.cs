using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Input
    {
        public int InPutnumber()
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

        public int InPuthand()
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

    }
}
