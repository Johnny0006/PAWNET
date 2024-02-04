using PAWNET.Model;

namespace PAWNET.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Dishes.Any())
            {
                return;
            }

            var dishes = new Dish[]
            {
            new Dish
            {
                Name = "Spaghetti Bolognese",
                Description = "Classic Italian dish with meat sauce",
                Price = 12.99,
                Category = "Pasta",
                IsVegetarian = false
            },
            new Dish
            {
                Name = "Margherita Pizza",
                Description = "Traditional pizza with tomato, mozzarella, and basil",
                Price = 10.99,
                Category = "Pizza",
                IsVegetarian = true
            },
                
            };

            context.Dishes.AddRange(dishes);
            context.SaveChanges();
        }
    }
}
