namespace RestaurantMenu
{
    public class MenuItem
    {
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
        Uncategorized,
        Appetizer,
        MainCourse,
        Dessert
    }
}
