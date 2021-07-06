using _01_CafeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CafeUI
{
    class ProgramUI
    {

        private MenuRepo _menuRepo = new MenuRepo();

        //Method that Runs/starts the application
        public void Run()
        {
            SeedMenuList();
            Menu();
        }

        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display the options to the user
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create new menu items\n" +
                    "2. View all menu items\n" +
                    "3. Delete menu items\n" +
                    "4. Exit");

                // Get the user's input
                string input = Console.ReadLine();

                //Evaluate the user's input and act accordingly
                switch (input)
                {
                    case "1":
                        //Create new menu items
                        CreateNewMenuItems();
                        break;
                    case "2":
                        //View all menu items
                        ViewAllMenuItems();
                        break;
                    case "3":
                        //Delete menu items
                        DeleteMenuItems();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye");
                        keepRunning = false;
                        //Exit
                        break;
                    default:
                        Console.WriteLine("Please enter a vaild number.");
                        break;
                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        //Creat new menu items
        private void CreateNewMenuItems()
        {
            Console.Clear();
            Menu newItem = new Menu();

            //Meal Number
            Console.WriteLine("Enter the number for the meal:");
            string numberAsString = Console.ReadLine();
            newItem.MealNumber = int.Parse(numberAsString);

            //Meal Name
            Console.WriteLine("Enter the name of meal:");
            newItem.MealName = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the meal descripton:");
            newItem.Description = Console.ReadLine();

            //Ingredietns
            Console.WriteLine("Enter the ingredients:");
            newItem.Ingredients = Console.ReadLine();

            //Price
            Console.WriteLine("Enter the price:");
            string priceAsString = Console.ReadLine();
            newItem.Price = decimal.Parse(priceAsString);

            _menuRepo.AddItemsToMenu(newItem);
        }

        // View all menu items
        private void ViewAllMenuItems()
        {
            Console.Clear();

            List<Menu> listOfItems = _menuRepo.GetMenuItems();

            foreach (Menu items in listOfItems)
            {
                Console.WriteLine($"MealNumber: {items.MealNumber}\n" +
                    $"MealName: {items.MealName}\n" +
                    $"Description: {items.Description}\n" +
                    $"Ingredients: {items.Ingredients}\n" +
                    $"Price: ${items.Price}\n");
            }
        }

        // Delete menu items
        private void DeleteMenuItems()
        {
            ViewAllMenuItems();
            Console.WriteLine("\nEnter the number of the meal you would like to remove.");

            int input = int.Parse(Console.ReadLine());

            bool wasDeleted = _menuRepo.RemoveItemFromMenu(input);

            if (wasDeleted)
            {
                Console.WriteLine("The menu item was successfully deleted.");
            }
            else
            {
                Console.WriteLine("The menu item could not be deleted.");
            }
        }

        //Seed Method
        private void SeedMenuList()
        {
            Menu surfAndTurf = new Menu(1, "Surf and Turf", "When you just can't decide.", "Shrimp, Chicken Nuggets, Fries, Drink", 18.99m);
            Menu texasTwister = new Menu(2, "Texas Twister", "Because everythings bigger in Texas!", "Brisket, Ribs, Sausage, Fries, Drink", 25.99m);
            Menu burgerBasket = new Menu(3, "Burger Basket", "Burgers make everything better!", "Cheeseburger, Fries, Drink", 10.99m);

            _menuRepo.AddItemsToMenu(surfAndTurf);
            _menuRepo.AddItemsToMenu(texasTwister);
            _menuRepo.AddItemsToMenu(burgerBasket);

        }
    }
}

