using DrinkMenu.Business.Abstract;
using DrinkMenu.Business.CrossCuttingConcern.DependencyResolves.Ninject;
using DrinkMenu.DataAccess.Abstract;
using DrinkMenu.Entities.Concrete;
using System;
using System.Linq;

namespace DrinkMenu.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {                    
            Console.WriteLine($"{"DrinkId",-15}{"Name",-15}{"perPackage",-15}{"UnitPrice",-15}\n");
            
            var drinkService = InstanceFactory.Get<IDrinkService>();
            drinkService.GetAll().ForEach(a => Console.WriteLine(a));

            Console.ReadKey();

        }
    }
}
