using _01_CafeLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_CafeTest
{
    [TestClass]
    public class CafeTest
    {
        [TestMethod]
        public void SetMealName_ShouldSetCorrectString()
        {
            Menu items = new Menu();

            items.MealName = "Surf and Turf";

            string expected = "Surf and Turf";
            string actual = items.MealName;

            Assert.AreEqual(expected, actual);
        }
    }
}
