using System;

namespace Printhalf
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows:\t");
            int rows = int.Parse(Console.ReadLine());
            int i, j;
            for (i = 1; i <= rows; ++i)
            {
               for (j = 1 ; j <= i; ++j)
                {
                Console.Write("* ");
                
            }
            Console.WriteLine();
        }
    }
}
}

