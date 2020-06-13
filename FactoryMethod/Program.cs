using System;
using FactoryMethod.Creators;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var tky = new TurkeySandwich();
            var dagWd = new DagwoodSandwich();
        }
    }
}
