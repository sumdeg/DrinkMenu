using DrinkMenu.DataAccess.Abstract;
using DrinkMenu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkMenu.DataAccess.Concrete.EntityFramework
{
    public class EfDrinkDal:EfRepositoryBase<Drink,DrinkMenuContext>,IDrinkDal
    {
    }
}
