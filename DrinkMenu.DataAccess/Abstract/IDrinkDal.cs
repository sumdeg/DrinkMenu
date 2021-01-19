using DrinkMenu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkMenu.DataAccess.Abstract
{
    public interface IDrinkDal : IEntityRepository<Drink>
    {
    }
}
