using System;
using System.Collections.Generic;

namespace Builder
{
    //added immutability, just for funsies
    public class IpaRecipe : IBeerRecipe
    {
        public IpaRecipe(
            string yeast,
            List<Grain> grains,
            List<Hop> hops,
            List<Adjunct> adjuncts,
            string boilTime,
            string fermentationTime,
            string mashTime)
        {
            Yeast = yeast;
            Grains = grains;
            Hops = hops;
            Adjuncts = adjuncts;
            BoilTime = boilTime;
            FermentationTime = fermentationTime;
            MashTime = mashTime;
        }

        public string Yeast { get; }
        public List<Grain> Grains { get; }
        public List<Hop> Hops { get;}
        public List<Adjunct> Adjuncts { get; }
        public string BoilTime { get; }
        public string FermentationTime { get; }
        public string MashTime { get; }
    }
}
