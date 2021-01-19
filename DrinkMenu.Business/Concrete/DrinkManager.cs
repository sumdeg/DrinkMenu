using DrinkMenu.Business.Abstract;
using DrinkMenu.DataAccess.Abstract;
using DrinkMenu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DrinkMenu.Business.Concrete
{
    public class DrinkManager : IDrinkService
    {
        private IDrinkDal _drink;

        public DrinkManager(IDrinkDal drink)
        {
            _drink = drink;
        }

        public void Add(Drink entity)
        {
            _drink.Add(entity);
        }

        public void Delete(Drink entity)
        {
            _drink.Delete(entity);
        }

        public Drink Get(int id)
        {
           return _drink.Get(id);
        }

        public List<Drink> GetAll()
        {
            return _drink.GetAll();
        }

        public void Update(Drink entity)
        {
            _drink.Update(entity);
        }
    }
}
