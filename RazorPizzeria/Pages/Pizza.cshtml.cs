using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>() 
        {
            new PizzasModel()
            {
                ImageTitel="Margerita", 
                PizzaName="Margerita", 
                BasePrice=2, 
                TomatoSauce=true, 
                Cheese=true, 
                FinalPrice=4
            },
            new PizzasModel()
            {
				ImageTitel="Bolognese",
				PizzaName="Bolognese",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
                Beef=true,
				FinalPrice=5
			},
			new PizzasModel()
			{
				ImageTitel="Carbonara",
				PizzaName="Carbonara",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				Ham=true,
                Peperoni=true,
				FinalPrice=8
			},
			new PizzasModel()
			{
				ImageTitel="Hawaiian",
				PizzaName="Hawaiian",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				Ham=true,
				Pineapple=true,
				FinalPrice=15
			},
			new PizzasModel()
			{
				ImageTitel="MeatFeast",
				PizzaName="MeatFeast",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				Ham=true,
				Beef=true,
				FinalPrice=10
			},
			new PizzasModel()
			{
				ImageTitel="Mushroom",
				PizzaName="Mushroom",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				Ham=true,
				Mushroom=true,
				FinalPrice=7
			},
			new PizzasModel()
			{
				ImageTitel="Pepperoni",
				PizzaName="Pepperoni",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				Peperoni=true,
				Ham=true,
				FinalPrice=8
			},
			new PizzasModel()
			{
				ImageTitel="Seafood",
				PizzaName="Seafood",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				Tuna=true,
				FinalPrice=10
			},
			new PizzasModel()
			{
				ImageTitel="Vegetarian",
				PizzaName="Vegetarian",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				Peperoni=true,
				Pineapple=true,
				Mushroom=true,
				FinalPrice=12
			}
		};

        public void OnGet()
        {
        }
    }
}
