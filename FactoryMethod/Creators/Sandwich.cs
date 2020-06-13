using System;
using System.Collections.Generic;
using FactoryMethod.Products;

namespace FactoryMethod.Creators
{
    //creator
    public abstract class Sandwich
    {
        public Sandwich()
        {
            CreateIngredients();
        }

        //Factory method
        public abstract void CreateIngredients();

        public List<IIngredient> Ingredients { get; }
            = new List<IIngredient>();
    }
}
