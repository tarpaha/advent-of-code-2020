using System.Collections.Generic;
using System.Linq;

namespace day_2020_12_21
{
    public static class Solver
    {
        public static int Part1(Problem problem)
        {
            var ingredientsWithoutAllergens = GetIngredientsWithoutAllergens(problem).ToHashSet();
            return problem.Foods
                .SelectMany(food => food.Ingredients)
                .Count(ingredient => ingredientsWithoutAllergens.Contains(ingredient));
        }

        public static string Part2(Problem problem)
        {
            
            return "";
        }

        public static IEnumerable<Ingredient> GetIngredientsWithoutAllergens(Problem problem)
        {
            return problem.Ingredients
                .Where(ingredient => !problem.Allergens.Any(allergen => IngredientCanContainAllergen(problem, ingredient, allergen)));
        }
        
        private static bool IngredientCanContainAllergen(Problem problem, Ingredient ingredient, Allergen allergen)
        {
            return problem.Foods
                .Where(food => food.Allergens.Contains(allergen))
                .All(food => food.Ingredients.Contains(ingredient));
        }
        
        public static Problem MakeProblemWithoutIngredientsAndAllergens(
            Problem problem,
            IEnumerable<Ingredient> ingredients,
            IEnumerable<Allergen> allergens)
        {
            var ingredientsToRemove = ingredients.ToHashSet();
            var allergensToRemove = allergens.ToHashSet();
            var updatedIngredients = problem.Ingredients.Where(ingredient => !ingredientsToRemove.Contains(ingredient));
            var updatedAllergens = problem.Allergens.Where(allergen => !allergensToRemove.Contains(allergen));
            var updatedFoods = problem.Foods.Select(food => new Food(
                food.Ingredients.Where(ingredient => !ingredientsToRemove.Contains(ingredient)),
                food.Allergens.Where(allergen => !allergensToRemove.Contains(allergen))));
            return new Problem(updatedFoods, updatedIngredients, updatedAllergens);
        }
    }
}