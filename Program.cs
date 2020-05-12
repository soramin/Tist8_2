﻿using System;

namespace List8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int result = 0;

            Console.WriteLine("整数を入力してください");

            string strNo = Console.ReadLine();

            x = int.Parse(strNo);

            if(!int.TryParse(strNo, out result))
            {
                Console.WriteLine("整数が入力されなかったため処理を終了します。");
                return;
            }

            Console.WriteLine($"入力した値は{result}です。");
        }
    }
}
