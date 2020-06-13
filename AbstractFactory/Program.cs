using System;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new IpaPairingFactory();
            test.GetBeer();
            test.GetFood();

        }
    }
}
