using System;

namespace Kigyo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hány almát evett meg a kígyó?");
            int alma = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hány körtét evett meg a kígyó?");
            int korte = Convert.ToInt32(Console.ReadLine());

            int hossz = alma * 10 + korte * 20;

            Console.WriteLine("A kígyó hossza: {0}",hossz);
        }
    }
}
