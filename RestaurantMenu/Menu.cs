using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    public class Menu
    {
        public DateTime LastUpdated { get; private set; }
        public List<MenuItem> MenuItems { get; private set; }

        public Menu()
        {
            LastUpdated = DateTime.Now;
            MenuItems = new List<MenuItem> 
            { 
                // The 'M' here forces 10.00 to be a 'decimal' type, 
                // rather than a 'double', which is standard for dollar representations in C#
                new MenuItem(10.00M, "pizza", Category.MainCourse, false),
                new MenuItem(8.00M, "cheesecake", Category.Dessert, true),
                new MenuItem(4.00M, "fries", Category.Appetizer, false)
            };
        }
    }
}
