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

            // var b = new Drink() {DrinkId=4,Name="Kahve",perPackage=0.3,UnitPrice=15};
            // var c=drinkService.Get(b=>b.DrinkId==1);


            //var list1=drinkService.Get(b => b.DrinkId == 2);
            // Console.WriteLine(list1);

            Console.WriteLine(drinkService.Get(2));

           
            
            
         
            
            Console.ReadKey();

        }
    }
}
