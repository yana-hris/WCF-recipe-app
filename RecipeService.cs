namespace RecipeWcfService
{
    using System;
    using System.Collections.Generic;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class RecipeService : IRecipeService
    {
        private static readonly List<Recipe> recipes = new List<Recipe>
        {
           new Recipe
            {
                Id = Guid.Parse("c0420eee-5291-41a5-bc00-8db342e0ccc0"),
                Name = "Spaghetti Bolognese",
                Description = "A classic Italian pasta dish with a rich and meaty tomato sauce.",
                ImageUrl = "https://img.taste.com.au/5qlr1PkR/taste/2016/11/spaghetti-bolognese-106560-1.jpeg",
                Ingredients = new List<string>
                {
                    "500g Ground Beef",
                    "500g Spaghetti",
                    "50g Parmesan Cheese",
                    "1 Onion, finely chopped",
                    "500g Crushed Tomatoes",
                    "2 cloves Garlic, minced",
                    "2 tbsp Olive Oil",
                    "1 tsp Oregano",
                    "1 tsp Basil",
                    "Salt and Pepper to taste"
                },
                Instructions = "1. Heat olive oil in a large pan and sauté onion and garlic until softened.\n" +
                               "2. Add ground beef and cook until browned.\n" +
                               "3. Pour in crushed tomatoes, oregano, basil, salt, and pepper. Simmer for 20 minutes.\n" +
                               "4. Meanwhile, cook spaghetti according to package instructions.\n" +
                               "5. Serve sauce over spaghetti and top with Parmesan cheese."
            },

            new Recipe
            {
                Id = Guid.Parse("cf6beb11-71ac-4019-8c68-8ae55b83213b"),
                Name = "Chicken Alfredo Pasta",
                Description = "A creamy and cheesy pasta dish with tender chicken and rich Alfredo sauce.",
                ImageUrl = "https://img.taste.com.au/lNw7Oe0u/taste/2016/11/chicken-alfredo-106400-1.jpeg",
                Ingredients = new List<string>
                {
                    "2 Chicken Breasts, sliced",
                    "300g Fettuccine Pasta",
                    "2 cups Heavy Cream",
                    "1 cup Parmesan Cheese, grated",
                    "3 cloves Garlic, minced",
                    "2 tbsp Butter",
                    "1 tbsp Olive Oil",
                    "Salt and Pepper to taste",
                    "Fresh Parsley for garnish"
                },
                Instructions = "1. Cook fettuccine according to package instructions.\n" +
                               "2. Heat olive oil and butter in a pan, then cook chicken until golden brown.\n" +
                               "3. Add garlic and cook for 1 minute.\n" +
                               "4. Pour in heavy cream and Parmesan cheese, stirring until sauce thickens.\n" +
                               "5. Toss pasta in the sauce and mix well.\n" +
                               "6. Garnish with fresh parsley and serve warm."
            }
        };

        public Recipe GetRecipeById(Guid id)
        {
            return recipes.Find(r => r.Id == id);
        }

        public List<Recipe> GetRecipes()
        {
            return recipes;
        }
    }
}
