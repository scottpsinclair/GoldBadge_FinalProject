using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe
{
    public class MenuRepo
    {
        public List<Menu> _listOfItems = new List<Menu>();

        //Create
        public void AddItemsToMenu(Menu items)
        {
            _listOfItems.Add(items);
        }

        //Read
        public List<Menu> GetMenuItems()
        {
            return _listOfItems;
        }

        //Update-Not Needed at this time

        //Delete
        public bool RemoveItemFromMenu(string mealName)
        {
            Menu item = GetItemByName(mealName);

            if( item == null)
            {
                return false;
            }

            int initialCount = _listOfItems.Count;
            _listOfItems.Remove(item);

            if(initialCount > _listOfItems.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper Method
        public Menu GetItemByName(string mealName)
        {
            foreach (Menu item in _listOfItems)
            {
                if (item.MealName == mealName)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
