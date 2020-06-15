using System;
using System.Collections.Generic;

namespace Builder
{
    public class IpaRecipeBuilder : IBeerRecipeBuilder
    {
        private string _fermentationTime;
        private List<Adjunct> _adjuncts = new List<Adjunct>();
        private List<Grain> _grains = new List<Grain>();
        private List<Hop> _hops = new List<Hop>();
        private string _boilTime;
        private string _mashtime;
        private string _yeast;
         
        public IBeerRecipe BuildRecipe()
        {
            return new IpaRecipe(
                _yeast,
                _grains,
                _hops,
                _adjuncts,
                _boilTime,
                _fermentationTime,
                _mashtime);
        }

        public void SetAdjunct(string ingredient, string amount, string measurement)
        {
            _adjuncts.Add(new Adjunct()
            {
                Name = ingredient,
                Amount = amount,
                Mesurement = measurement
            });
        }

        public void SetBoilTime(int minutes)
        {
            _boilTime = $"{minutes} min";
        }

        public void SetFermentationTime(int days)
        {
            _fermentationTime = $"{days} days";
        }

        public void SetGrain(string grain, int amountInPounds)
        {
            _grains.Add(new Grain()
            {
                Name = grain,
                AmountInPounds = amountInPounds
            });
        }

        public void SetHop(string hops, int amountInOunces)
        {
            _hops.Add(new Hop()
            {
                Name = hops,
                AmountInOunces = amountInOunces
            });
        }

        public void SetMashTime(int minutes)
        {
            _mashtime = $"{minutes} minutes";
        }

        public void SetWater(string profile, int amountInGallons)
        {
            throw new NotImplementedException();
        }

        public void SetYeast(string yeastStrain)
        {
            _yeast = yeastStrain;
        }
    }
}
