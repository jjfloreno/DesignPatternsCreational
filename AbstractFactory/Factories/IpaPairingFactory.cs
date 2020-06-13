using System;
using AbstractFactory.Models;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    //concrete factory
    public class IpaPairingFactory : IBeerPairingFactory
    {
        public BeerStyle CreateBeer()
        {
            return new Ipa
            {
                Beer = new Beer("Bell's Two Hearted")
            };
        }

        public Food CreateFood()
        {
            return new RedCurry();
        }
    }
}
