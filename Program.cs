using System;

// castingo conversao de um valor de um tipo para outro
namespace Couse
{
    class Program
    {
        static void Main(string[] args)
        {
           double a;
           int b;

           a = 5.1;
           b = (int) a;

            System.Console.WriteLine(b);
        }
    }
}