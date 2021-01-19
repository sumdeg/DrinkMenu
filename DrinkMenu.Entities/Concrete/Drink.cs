using DrinkMenu.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkMenu.Entities.Concrete
{
    public class Drink : IEntity
    {
        public int DrinkId { get; set; }
        public string Name { get; set; }
        public double perPackage { get; set; }
        public decimal UnitPrice { get; set; }

        public Drink()
        {

        }

        public Drink(string name, double perPackage, decimal unitPrice)
        {
            Name = name;
            this.perPackage = perPackage;
            UnitPrice = unitPrice;
        }

        public override string ToString()
        {
            return  $"{DrinkId,-15}{Name,-15}{perPackage,-15}{UnitPrice,-15}";
        }
    }
}
