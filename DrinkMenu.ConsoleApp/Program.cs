using DrinkMenu.Business.Abstract;
using DrinkMenu.Business.CrossCuttingConcern.DependencyResolves.Ninject;
using DrinkMenu.DataAccess.Abstract;
using DrinkMenu.Entities.Concrete;
using System;

namespace DrinkMenu.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var a= $"{"DrinkId",-15}{"Name",-15}{"perPackage",-15}{"UnitPrice",-15}";
            Console.WriteLine(a);
            Console.WriteLine();
            var drinkService = InstanceFactory.Get<IDrinkService>();
            drinkService.GetAll().ForEach(b => Console.WriteLine(b));
            
            Console.ReadKey();

        }
    }
}
