using System;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    //concrete factory
    public class IpaPairingFactory : IBeerPairingFactory
    {
        public BeerStyle GetBeer()
        {
            return new Ipa();
        }

        public Food GetFood()
        {
            return new RedCurry();
        }
    }
}
