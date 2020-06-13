using System;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    //concrete factory
    public class SourBeerPairingFactory : IBeerPairingFactory
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
