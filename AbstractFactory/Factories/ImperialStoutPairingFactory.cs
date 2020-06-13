using System;
using AbstractFactory.Models;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public class ImperialStoutPairingFactory : IBeerPairingFactory
    {
        public BeerStyle CreateBeer()
        {
            return new ImperialStout()
            {
                Beer = new Beer("Oskar Blues Ten Fidy")
            };
        }

        public Food CreateFood()
        {
            return new DarkChocolate();
        }
    }
}
