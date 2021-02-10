using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> City = new Dictionary<int, string>();

            City.Add(9, "Aydın");
            City.Add(35, "İzmir");
            City.Add(42, "Konya");
            City.Add(16, "Bursa");

            Console.Write("Enter your car plate:");
            int Plaka = Convert.ToInt16(Console.ReadLine());

            try
            {
                Console.WriteLine(City[Plaka]);
            }
            catch
            {
                Console.WriteLine("City is not found...");
            }
        }
    }
}
