using System;

namespace HD_qmercury_0329_1.cs
{
    class Program
    {
        static void Main(string[] args)
        {// for를 이용하여 3단, 6단, 9단 구구단을 만드는 프로그램을 작성하기

            for(int i = 3; i < 10; i = i + 3)
            {
                for(int j = 1; j <10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");

                }
            }
            
        }
    }
}
