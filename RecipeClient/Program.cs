namespace RecipeClient
{
    using System;

    class Program
    {
        static void Main()
        {
            RecipeServiceClient client = new RecipeServiceClient();

            Console.WriteLine("Fetching recipes...");

            var recipes = client.GetRecipes();


            foreach (var recipe in recipes)
            {
                Console.WriteLine("\n=====================================");
                Console.WriteLine($" RECIPE: {recipe.Name}");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($" Description: {recipe.Description}");
                Console.WriteLine($" Image URL: {recipe.ImageUrl}");
                Console.WriteLine("\n INGREDIENTS:");

                foreach (var ingredient in recipe.Ingredients)
                {
                    Console.WriteLine($"   - {ingredient}");
                }

                Console.WriteLine("\n INSTRUCTIONS:");
                Console.WriteLine($"{recipe.Instructions}");
                Console.WriteLine("=====================================\n");
            }

            // Call GetRecipeById(1)
            Console.WriteLine("\nFetching recipe with ID 1...");
            var recipeById = client.GetRecipeById(Guid.Parse("c0420eee-5291-41a5-bc00-8db342e0ccc0"));
            Console.WriteLine($"{recipeById.Id}: {recipeById.Name} - {string.Join(", ", recipeById.Ingredients)}");

            // Close client connection
            client.Close();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
