using System;
using FactoryMethod.Products;

namespace FactoryMethod.Creators
{
    //concrete creator
    public class TurkeySandwich : Sandwich
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mustard());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Bread());
        }
    }
}
