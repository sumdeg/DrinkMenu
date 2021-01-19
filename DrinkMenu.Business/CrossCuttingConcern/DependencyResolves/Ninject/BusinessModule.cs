using DrinkMenu.Business.Abstract;
using DrinkMenu.Business.Concrete;
using DrinkMenu.DataAccess.Abstract;
using DrinkMenu.DataAccess.Concrete.ADONET;
using DrinkMenu.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkMenu.Business.CrossCuttingConcern.DependencyResolves.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDrinkService>().To<DrinkManager>().InSingletonScope();
           // Bind<IDrinkDal>().To<EfDrinkDal>().InSingletonScope();
          Bind<IDrinkDal>().To<AdoDrinkDal>().InSingletonScope();
        }
    }
}
