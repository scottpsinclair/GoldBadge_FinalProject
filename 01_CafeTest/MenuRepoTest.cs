using _01_CafeLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_CafeTest
{
    [TestClass]
    public class MenuRepoTest
    {
        private MenuRepo _repo;
        private Menu _items;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new MenuRepo();
            _items = new Menu(1, "Surf and Turf", "For the person who just can't decide!", "Shrimp, Chicken Tenders, Fries, Drink", 18.99m);
            _repo.AddItemsToMenu(_items);
        }

        //Add Method
        [TestMethod]
        public void AddItemsToMenu_ShouldGetNotNull()
        {
            Menu items = new Menu();
            MenuRepo repo = new MenuRepo();

            bool addResult = repo.AddItemsToMenu(items);

            Assert.IsTrue(addResult);
        }

        //See all item in menu
        [TestMethod]
        public void GetMenuItems_SholdReturnCorrectCollection()
        {
            Menu testContent = new Menu(1, "Texas Twister", "Everythings Bigger In Texas", "brisket, ribs, sausage, fries, drink", 24.99m);
            MenuRepo repo = new MenuRepo();
            repo.AddItemsToMenu(testContent);

            List<Menu> items = repo.GetMenuItems();
            bool menuHasItems = items.Contains(testContent);

            Assert.IsTrue(menuHasItems);
        }

        //Delete Menu Items
        [TestMethod]
        public void RemoveItemFromMenu_ShouldReturnTrue()
        {
            int input = int.Parse(Console.ReadLine());
            Menu foundContent = _repo.GetItemByMealNumber(1);

            bool removeResult = _repo.RemoveItemFromMenu(foundContent);

            Assert.IsTrue(removeResult);
        }
    }
}
