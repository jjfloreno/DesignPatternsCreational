using System;
namespace Builder
{
    //builder
    public interface IBeerRecipeBuilder
    {
        public void SetGrain(string grain, int amountInPounds);
        public void SetHop(string hops, int amountInOunces);
        public void SetYeast(string yeastStrain);
        public void SetWater(string profile, int amountInGallons);
        public void SetAdjunct(string ingredient, string amount, string measurement);
        public void SetBoilTime(int minutes);
        public void SetMashTime(int minutes);
        public void SetFermentationTime(int days);
        public IBeerRecipe BuildRecipe();
    }
}
