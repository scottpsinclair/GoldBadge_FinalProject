using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CafeLibrary
{
    public class MenuRepo
    {
        public List<Menu> _listOfItems = new List<Menu>();

        //Create
        public bool AddItemsToMenu(Menu items)
        {
            int startingCount = _listOfItems.Count;
            _listOfItems.Add(items);
            bool wasAdded = (_listOfItems.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Read
        public List<Menu> GetMenuItems()
        {
            return _listOfItems;
        }

        //Update-Not Needed at this time

        //Delete
        public bool RemoveItemFromMenu(int mealNumber)
        {
            Menu items = GetItemByMealNumber(mealNumber);

            if (items == null)
            {
                return false;
            }

            int initialCount = _listOfItems.Count;
            _listOfItems.Remove(items);

            if (initialCount > _listOfItems.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper Method
        public Menu GetItemByMealNumber(int mealNumber)
        {
            foreach (Menu items in _listOfItems)
            {
                if (items.MealNumber == mealNumber)
                {
                    return items;
                }
            }

            return null;
        }

        public bool RemoveItemFromMenu(Menu foundContent)
        {
            throw new NotImplementedException();
        }
    }
}
