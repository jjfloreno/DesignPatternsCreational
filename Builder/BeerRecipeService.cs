using System;
namespace Builder
{
    //director
    public class BeerRecipeService
    {
        private IBeerRecipeBuilder _builder;

        public BeerRecipeService(IBeerRecipeBuilder beerRecipeBuilder)
        {
            _builder = beerRecipeBuilder;
        }

        public void CreateRecipe()
        {
        }
    }
}
