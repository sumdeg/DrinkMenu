using DrinkMenu.DataAccess.Abstract;
using DrinkMenu.Entities.Concrete;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DrinkMenu.DataAccess.Concrete.ADONET
{
    public class AdoDrinkDal : IEntityRepository<Drink>, IDrinkDal
    {
        public void Add(Drink entity)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Drinks (Name,perPackage,UnitPrice) VALUES (@Name,@perPackage,@UnitPrice)"))
            {
                cmd.Parameters.AddWithValue("Name", entity.Name);
                cmd.Parameters.AddWithValue("perPackage", entity.perPackage);
                cmd.Parameters.AddWithValue("UnitPrice", entity.UnitPrice);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public void Delete(Drink entity)
        {
            using (SqlCommand cmd =
                new SqlCommand("DELETE FROM Drinks where DrinkId = @DrinkId"))
            {
                cmd.Parameters.AddWithValue("DrinkId", entity.DrinkId);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public Drink Get(int id)
        {
            SqlCommand cmd = new SqlCommand("Select * from Drinks where DrinkId=@DrinkId");
            cmd.Parameters.AddWithValue("DrinkId", id);
            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                Drink drink = new Drink
                {
                    DrinkId = Convert.ToInt32(reader[0]),
                    Name = reader[1].ToString(),
                    perPackage = double.Parse(reader[2].ToString()),
                    UnitPrice = decimal.Parse(reader[3].ToString())
                };

                return drink;
            }
            return null;
           
        }

        public List<Drink> GetAll()
        {
            var drinkList = new List<Drink>();
            SqlCommand cmd = new SqlCommand("Select * from Drinks");

            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                Drink drink = new Drink
                {
                    DrinkId = Convert.ToInt32(reader[0]),
                    Name = reader[1].ToString(),
                    perPackage = double.Parse(reader[2].ToString()),
                    UnitPrice = decimal.Parse(reader[3].ToString())
                };

                drinkList.Add(drink);
            }
            return drinkList;
        }

        public void Update(Drink entity)
        {
            using (SqlCommand cmd =
               new SqlCommand("UPDATE Drinks set Name = @Name, perPackage = @perPackage, UnitPrice = @UnitPrice where DrinkId = @DrinkId"))
            {
                cmd.Parameters.AddWithValue("DrinkId", entity.DrinkId);
                cmd.Parameters.AddWithValue("Name", entity.Name);
                cmd.Parameters.AddWithValue("perPackage", entity.perPackage);
                cmd.Parameters.AddWithValue("UnitPrice", entity.UnitPrice);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }
    }
}
