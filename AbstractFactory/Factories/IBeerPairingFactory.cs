using System;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    // factory
    public interface IBeerPairingFactory
    {
        public BeerStyle GetBeer();
        public Food GetFood();
    }
}
