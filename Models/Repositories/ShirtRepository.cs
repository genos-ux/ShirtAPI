namespace WebAPIDemo.Models.Repositories
{
    public class ShirtRepository
    {
        private static List<Shirt> shirts = new List<Shirt>()
        {
            new Shirt {ShirtId = 1, BrandName = "My Brand", Color="blue", Gender = "Men",Price = 30, Size=10},
            new Shirt {ShirtId = 2, BrandName = "My Brand", Color = "Black", Gender = "Men",Price=35, Size=12},
            new Shirt {ShirtId = 3, BrandName = "Your Brand", Color = "Pink", Gender = "Women", Price = 28, Size= 8},
            new Shirt {ShirtId = 4, BrandName = "Your Brand", Color = "Yellow", Gender = "Women", Price = 30, Size = 9}
        };

        public static bool ShirtExist(int id)
        {
            return shirts.Any(x => x.ShirtId == id);
        }

        public static Shirt? GetShirtById(int id)
        {
            return shirts.FirstOrDefault(x => x.ShirtId == id);
        }
    }
}
