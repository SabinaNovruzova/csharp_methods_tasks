using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 374;
            int result = NumLength(num);
            Console.WriteLine(result);
        }
        static int NumLength(int num)
        {
            int count = 0;
            for (int i = 0; i < num; i++)
            {
                num = num / 10;
                count++;
            }
            return count;
        }
    }
}
