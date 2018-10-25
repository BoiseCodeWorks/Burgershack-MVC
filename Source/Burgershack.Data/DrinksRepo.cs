using Burgershack.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Burgershack.Data
{
    public interface IDrinksRepo
    {
        //crud
        Drink GetById(int id);
        Drink Update(Drink burger);
        List<Drink> GetAll();
        Drink Create(Drink burger);
    }

    public class DrinksRepo : IDrinksRepo
    {
        private readonly IDbConnection _db;

        public List<Drink> GetAll()
        {
            return FakeDb.Drinks;
        }

        public Drink GetById(int id)
        {
            return FakeDb.Drinks.Find(b => b.Id == id);
        }

        public Drink Update(Drink drink)
        {
            var b = GetById(drink.Id);
            if (b == null) { throw new Exception("Drink not found, Bad ID"); }
            b.Name = drink.Name;
            b.Description = drink.Description;
            b.Price = drink.Price;
            return b;
        }

        public Drink Create(Drink drink)
        {
            drink.Id = FakeDb.NextId;
            FakeDb.NextId += 1;
            FakeDb.Drinks.Add(drink);
            return drink;
        }

        public DrinksRepo(IDbConnection db)
        {
            _db = db;
        }
    }
}
