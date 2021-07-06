using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CafeLibrary
{
    public class Menu
    {
        //Properties

        public int MealNumber
        {
            get; set;
        }
        public string MealName
        {
            get; set;
        }
        public string Description
        {
            get; set;
        }
        public string Ingredients
        {
            get; set;
        }
        public decimal Price
        {
            get; set;
        }

        public Menu()
        {
        }

        public Menu(int mealNumber, string mealName, string description, string ingredients, decimal price)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            Ingredients = ingredients;
            Price = price;
        }
    }
}
