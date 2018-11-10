using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Rider rider = new Rider();
            rider.RideCar();

            Console.ReadKey();
        }
    }
}
