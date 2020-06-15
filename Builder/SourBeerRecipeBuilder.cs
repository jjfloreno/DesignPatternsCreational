using System;
namespace Builder
{
    public class SourBeerRecipeBuilder : IBeerRecipeBuilder
    {
        public IBeerRecipe BuildRecipe()
        {
            throw new NotImplementedException();
        }

        public void SetAdjunct(string ingredient, string amount, string measurement)
        {
            throw new NotImplementedException();
        }

        public void SetBoilTime(int minutes)
        {
            throw new NotImplementedException();
        }

        public void SetFermentationTime(int days)
        {
            throw new NotImplementedException();
        }

        public void SetGrain(string grain, int amountInPounds)
        {
            throw new NotImplementedException();
        }

        public void SetHop(string hops, int amountInOunces)
        {
            throw new NotImplementedException();
        }

        public void SetMashTime(int minutes)
        {
            throw new NotImplementedException();
        }

        public void SetWater(string profile, int amountInGallons)
        {
            throw new NotImplementedException();
        }

        public void SetYeast(string yeastStrain)
        {
            throw new NotImplementedException();
        }
    }
}
