using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM24MBH.Data
{
    internal class PetFoodProduct : IProduct
    {
        public Int32 Id { get; set; }
        public Boolean isSelected { get; set; }
        public String Brand { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Decimal Price { get; set; }
        public Int32 Quantity { get; set; }

        public PetFoodProduct(Int32 id, String brand, String name, String description, Decimal price, Int32 quantity)
        {
            Id = id;
            Brand = brand;
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
        }
    }


    public static class TestIProducts
    {
        public static readonly List<IProduct> Products = new List<IProduct>
        {
            new PetFoodProduct(1, "Primal Pet Foods", "Primal Powerhouse", "Raw-infused kibble packed with real meat, organs, and bones", 49.99m, 12),
            new PetFoodProduct(2, "Oceanic Nutrition", "Ocean's Bounty", "Holistic dog food with wild-caught salmon, marine algae, and omega-3s", 44.99m, 15),
            new PetFoodProduct(3, "Champion Chow", "Beef & Barley Medley", "Hearty blend with essential nutrients", 29.99m, 20),
            new PetFoodProduct(4, "Paws & Play", "Puppy Powerhouse", "Specially formulated for brain development", 42.99m, 10),
            new PetFoodProduct(5, "Golden Years", "Senior Serenity", "Gentle, easy-to-digest senior dog food", 32.99m, 12),
            new PetFoodProduct(6, "Lean Machine", "Weight Management Formula", "Low-calorie, high-protein for healthy weight", 34.99m, 18),
            new PetFoodProduct(7, "Hypoallergenic Haven", "Hypoallergenic Venison and Pea", "Grain-free option for sensitive skin", 39.99m, 15),
            new PetFoodProduct(8, "Omega-3 Power Blend", "Omega-3 Rich Fish Oil", "Supplement to enhance skin health", 24.99m, 10),
            new PetFoodProduct(9, "Nourishing Stew", "Beef and Sweet Potato Stew with Bone Broth", "Moist, flavorful stew for a delicious meal", 36.99m, 12),
            new PetFoodProduct(10, "Superfood Symphony", "Chicken and Vegetable Medley with Superfoods", "Balanced meal with superfoods", 38.99m, 15),
            new PetFoodProduct(11, "Limited Ingredient Duck and Apple", "Limited Ingredient Diet", "Simple, hypoallergenic formula", 42.99m, 10),
            new PetFoodProduct(12, "Bone Broth Elixir", "Beef and Bone Broth Elixir", "Concentrated bone broth supplement", 29.99m, 8),
            new PetFoodProduct(13, "Coconut Cravings", "Grain-Free Salmon and Sweet Potato with Coconut Oil", "Flavorful, grain-free option", 37.99m, 12),
            new PetFoodProduct(14, "Puppy Prime", "Puppy Starter Formula with Colostrum", "Gentle, easily digestible formula", 44.99m, 10),
            new PetFoodProduct(15, "Oatmeal Oasis", "Sensitive Skin Salmon with Oatmeal", "Grain-free formula for sensitive skin", 39.99m, 15),
            new PetFoodProduct(16, "Chia Seed Crunch", "Beef and Oatmeal Medley with Chia Seeds", "Balanced meal with chia seeds", 38.99m, 12),
            new PetFoodProduct(17, "Green Tea Boost", "Weight Management Chicken and Rice with Green Tea Extract", "Low-calorie, high-protein option", 36.99m, 15),
            new PetFoodProduct(18, "Turmeric Tonic", "Senior Beef and Rice with Turmeric", "Gentle, easy-to-digest senior dog food", 34.99m, 12),
            new PetFoodProduct(19, "Pumpkin Patch", "Hypoallergenic Lamb and Rice with Pumpkin", "Grain-free option for sensitive skin", 39.99m, 15),
            new PetFoodProduct(20, "Omega-3 Chews", "Omega-3 Rich Fish Oil Soft Chews", "Convenient way to supplement your dog's diet", 26.99m, 10),
            new PetFoodProduct(21, "Cranberry Craze", "Beef and Vegetable Stew with Quinoa and Cranberries", "Hearty stew with added antioxidants", 39.99m, 12),
            new PetFoodProduct(22, "Leafy Greens Medley", "Chicken and Rice Medley with Kale and Spinach", "Nutrient-dense and fiber-rich option", 38.99m, 15),
            new PetFoodProduct(23, "Rabbit and Sweet Potato", "Limited Ingredient Rabbit and Sweet Potato", "Simple, hypoallergenic formula", 42.99m, 10),
            new PetFoodProduct(24, "Probiotic Power", "Beef and Bone Broth Cubes with Probiotics", "Convenient way to add bone broth and probiotics", 29.99m, 8),
            new PetFoodProduct(25, "Spirulina Superfood", "Grain-Free Salmon and Sweet Potato with Spirulina", "Flavorful, grain-free option with spirulina", 37.99m, 12),
            new PetFoodProduct(26, "Feline Feast", "Ocean-Fresh Salmon Flakes", "High-protein, grain-free for delicious meals", 34.99m, 18),
            new PetFoodProduct(27, "Purrfect Plate", "Chicken & Tuna Medley", "Flavorful blend packed with essential nutrients", 27.99m, 15),
            new PetFoodProduct(28, "Kitten Kaboodle", "Kitten Cravings", "Specially formulated for brain development", 39.99m, 8),
            new PetFoodProduct(29, "Senior Serenity", "Gentle Care", "Gentle, easy-to-digest senior cat food", 32.99m, 12),
            new PetFoodProduct(30, "Indoor Bliss", "Indoor Cat Formula", "Balanced diet specifically designed for indoor cats", 36.99m, 15),
            new PetFoodProduct(31, "Hypoallergenic Haven", "Hypoallergenic Chicken and Rice", "Grain-free option for sensitive skin", 39.99m, 15),
            new PetFoodProduct(32, "Omega-3 Power Blend", "Omega-3 Rich Fish Oil", "Supplement to enhance skin health", 24.99m, 10),
            new PetFoodProduct(33, "Creamy Delight", "Chicken and Tuna Pate", "Creamy, flavorful pate", 34.99m, 12),
            new PetFoodProduct(34, "Seafood Sensation", "Salmon and Vegetable Medley", "Balanced meal with real salmon", 38.99m, 15),
            new PetFoodProduct(35, "Limited Ingredient Duck and Apple", "Limited Ingredient Diet", "Simple, hypoallergenic formula", 42.99m, 10),
            new PetFoodProduct(36, "Bone Broth Elixir", "Chicken and Tuna Broth", "Nourishing broth supplement", 29.99m, 8),
            new PetFoodProduct(37, "Coconut Cravings", "Grain-Free Salmon and Sweet Potato with Coconut Oil", "Flavorful, grain-free option", 37.99m, 12),
            new PetFoodProduct(38, "Kitten Starter Formula", "Kitten Starter Formula", "Gentle, easily digestible formula", 44.99m, 10),
            new PetFoodProduct(39, "Oatmeal Oasis", "Sensitive Skin Salmon with Oatmeal", "Grain-free formula for sensitive skin", 39.99m, 15),
            new PetFoodProduct(40, "Chia Seed Crunch", "Chicken and Oatmeal Medley with Chia Seeds", "Balanced meal with chia seeds", 38.99m, 12),
            new PetFoodProduct(41, "Green Tea Boost", "Weight Management Chicken and Rice with Green Tea Extract", "Low-calorie, high-protein option", 36.99m, 15),
            new PetFoodProduct(42, "Turmeric Tonic", "Senior Chicken and Rice with Turmeric", "Gentle, easy-to-digest senior cat food", 34.99m, 12),
            new PetFoodProduct(43, "Pumpkin Patch", "Hypoallergenic Lamb and Rice with Pumpkin", "Grain-free option for sensitive skin", 39.99m, 15),
            new PetFoodProduct(44, "Omega-3 Chews", "Omega-3 Rich Fish Oil Soft Chews", "Convenient way to supplement your cat's diet", 26.99m, 10),
            new PetFoodProduct(45, "Cranberry Craze", "Chicken and Vegetable Stew with Quinoa and Cranberries", "Hearty stew with added antioxidants", 39.99m, 12),
            new PetFoodProduct(46, "Leafy Greens Medley", "Turkey and Noodles Medley with Greens and Catnip", "Nutrient-dense and fiber-rich option", 38.99m, 15),
            new PetFoodProduct(47, "Indoor Bliss", "Indoor Cat Formula", "Balanced diet specifically designed for indoor cats", 36.99m, 15),
            new PetFoodProduct(48, "Hypoallergenic Haven", "Hypoallergenic Chicken and Rice", "Grain-free option for sensitive skin", 39.99m, 15),
            new PetFoodProduct(49, "Omega-3 Power Blend", "Omega-3 Rich Fish Oil", "Supplement to enhance skin health", 24.99m, 10),
            new PetFoodProduct(50, "Creamy Delight", "Chicken and Tuna Pate", "Creamy, flavorful pate", 34.99m, 12),
            // Add more products here...
        };

        public static Dictionary<Int32, IProduct> GetTestProducts()
        {
            Debug.WriteLine("GetTestProducts()");
            var products = new Dictionary<Int32, IProduct>();
            foreach (var product in Products)
            {
                products.Add(product.Id, product);
            }
            return products;
        }
    }
}
