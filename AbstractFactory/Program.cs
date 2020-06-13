using System;
using AbstractFactory.Factories;
using AbstractFactory.Models;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: IPA");
            Console.WriteLine("2: Sour");
            Console.WriteLine("3: Imperial Stout");
            var input = Console.ReadKey().KeyChar.ToString();
            IBeerPairingFactory factory;

            switch(input)
            {
                case "1":
                    factory = new IpaPairingFactory();
                    break;
                case "2":
                    factory = new SourBeerPairingFactory();
                    break;
                case "3":
                    factory = new ImperialStoutPairingFactory();
                    break;
                default:
                    throw new NotImplementedException("Not a recognized input");
            }

            var beer = factory.CreateBeer().Beer;
            var food = factory.CreateFood();

            Console.WriteLine();
            Console.WriteLine($"Beer: {beer.Name}");
            Console.WriteLine($"Food: {food.GetType().Name}");
            Console.WriteLine();
        }
    }
}
