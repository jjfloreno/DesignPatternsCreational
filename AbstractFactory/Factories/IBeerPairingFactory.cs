using System;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    // factory
    public interface IBeerPairingFactory
    {
        public BeerStyle CreateBeer();
        public Food CreateFood();
    }
}
