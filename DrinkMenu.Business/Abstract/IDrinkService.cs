using DrinkMenu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DrinkMenu.Business.Abstract
{
    public interface IDrinkService
    {
        List<Drink> GetAll();
        Drink Get(int id);
        void Add(Drink entity);
        void Update(Drink entity);
        void Delete(Drink entity);
    }
}
