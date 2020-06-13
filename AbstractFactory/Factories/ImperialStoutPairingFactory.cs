using System;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public class ImperialStoutPairingFactory : IBeerPairingFactory
    {
        public BeerStyle GetBeer()
        {
            throw new NotImplementedException();
        }

        public Food GetFood()
        {
            throw new NotImplementedException();
        }
    }
}
