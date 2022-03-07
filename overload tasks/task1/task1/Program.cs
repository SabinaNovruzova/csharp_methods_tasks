using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sahe(5,4));
        }
        #region cevrenin sahesi
        static int Sahe(int side)
        {
            return side * side * 3;
        }
        #endregion
        #region duzbucaqlinin sahesi
        static int Sahe(int a, int b)
        {
            return a * b;
        }
        #endregion
       #region duzbucaqli paralelipedin tam sethinin sahesi
        static int Sahe(int a, int b, int c)
        {
            return 2 * (a * b + a * c + b * c);
        }
        #endregion
        #region ucbucaqlinin daxiline cekilmis cevrenin sahesi
        static int Sahe(int a, int b, int c, int r)
        {
            return ((a + b + c) / 2) * r;
        }
        #endregion
    }
}
