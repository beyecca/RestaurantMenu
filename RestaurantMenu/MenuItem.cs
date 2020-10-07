namespace RestaurantMenu
{
    public class MenuItem
    {
        // I used {get; private set;} syntax here because it is shorter 
        // and allows me to access each property on a new instance of the class, like:
        //      MenuItem item = new MenuItem()
        //      decimal price = item.Price
        //
        // but protects me from setting the property:
        //      MenuItem item = new MenuItem()
        //      item.Price = 12.00M (this will throw an error)

        public decimal Price { get; private set; }
        public string Description { get; private set; }
        public Category Category { get; private set; }
        public bool IsNew { get; private set; }

        public MenuItem(decimal price, string description, Category category, bool isNew)
        {
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
        }
    }

    public enum Category 
    { 
        Appetizer,
        MainCourse,
        Dessert
    }
}
