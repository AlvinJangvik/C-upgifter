using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Random = new Random();
            int num = Random.Next(1, 101);
            int f = 0;
            bool loop = true;
            Console.WriteLine("Gissa ett tal mellan 1 och 100");
            while (loop == true)
            {
                int g = Convert.ToInt32(Console.ReadLine());
                f++;
                if (g == num)
                {
                    Console.WriteLine("Rätt :)");
                    Console.WriteLine("Du gjorde det på: " + f + " Försök");
                    loop = false;
                }
                else if (g <= num)
                {
                    Console.WriteLine("För lågt");
                }
                else if (g >= num)
                {
                    Console.WriteLine("För högt");
                }
                else
                {
                    Console.WriteLine("Inte äns ett nummer");
                }
            }
        }
    }
}
