using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace examen_entity_framework
{
    class Program
    {
        static void Main(string[] args)
        {
            //var Pizza = new Pizzas();
            //var profit = ConfigurationManager.AppSettings["Profits"];
            //var price = Pizza.IngredientsLinks.Sum(c => c.IngredientsPrice);



            /*List <Pizzas> lista = new List<Pizzas>()
            {
                new Pizzas { PizzasName = "Napolitana"},
                new Pizzas { PizzasName = "Hawaiana"},
                new Pizzas {PizzasName = "Margarita"},
                new Pizzas {PizzasName = "cuatro quesos"}
            };

            ICollection<Ingredients> ingredientes = new List<Ingredients>()
            {
                new Ingredients {IngredientsName = "queso"},
                new Ingredients {IngredientsName = "carne"}
            };

            ICollection<Ingredients> ingredientes2 = new List<Ingredients>()
            {
                new Ingredients {IngredientsName = "queso"},
                new Ingredients {IngredientsName = "carne pollo"}
            };

            lista[0].IngredientsLinks = ingredientes;
            lista[1].IngredientsLinks = ingredientes2;

           
            using(var db = new PizzasIngredientsContext())
            {
                var pizzaRepository = new PizzasRepository(db);
                foreach (var item in lista)
                {
                    db.Pizzas.Add(item);
                    
                }

            db.SaveChanges();
            }*/



        }
    }
}
