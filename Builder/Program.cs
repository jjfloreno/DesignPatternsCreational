using System;
using Newtonsoft.Json;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Beer Recipe Creator");

            var ipaBuilder = new IpaRecipeBuilder();
            ipaBuilder.SetGrain("Golden Promise", 10);
            ipaBuilder.SetGrain("Maris Otter", 2);
            ipaBuilder.SetGrain("Flaked Oats", 2);
            ipaBuilder.SetHop("Mosaic", 8);
            ipaBuilder.SetHop("Galaxy", 8);
            ipaBuilder.SetYeast("WLP 002");
            ipaBuilder.SetBoilTime(60);
            ipaBuilder.SetMashTime(60);
            ipaBuilder.SetFermentationTime(14);
             var beer = ipaBuilder.BuildRecipe();

            Console.WriteLine(JsonConvert.SerializeObject(beer, Formatting.Indented));
        }
    }
}
