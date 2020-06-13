using System;
using AbstractFactory.Models;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    //concrete factory
    public class SourBeerPairingFactory : IBeerPairingFactory
    {
        public BeerStyle CreateBeer()
        {
            return new Lambic()
            {
                Beer = new Beer("Drie Fonteinen Oude Gueuze")
            };
        }

        public Food CreateFood()
        {
            return new Chevre();
        }
    }
}
