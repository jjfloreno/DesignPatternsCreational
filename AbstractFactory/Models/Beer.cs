using System;
namespace AbstractFactory.Models
{
    public class Beer
    {
        public Beer(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
