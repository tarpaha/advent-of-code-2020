using System.Collections.Generic;
using System.Linq;

namespace day_2020_12_21
{
    public static class Solver
    {
        public static int Part1(Problem problem)
        {
            bool IngredientCanContainAllergen(Ingredient ingredient, Allergen allergen)
            {
                return problem.Foods
                    .Where(food => food.Allergens.Contains(allergen))
                    .All(food => food.Ingredients.Contains(ingredient));
            }

            var ingredientWithoutAllergens = problem.Ingredients
                .Where(ingredient => !problem.Allergens.Any(allergen => IngredientCanContainAllergen(ingredient, allergen)))
                .ToHashSet();

            return problem.Foods
                .SelectMany(food => food.Ingredients)
                .Count(ingredient => ingredientWithoutAllergens.Contains(ingredient));
        }

        public static string Part2(Problem problem)
        {
            return "";
        }

        public static Problem MakeProblemWithoutIngredients(Problem problem, IEnumerable<Ingredient> ingredients)
        {
            var ingredientsToRemove = ingredients.ToHashSet();
            var updatedIngredients = problem.Ingredients.Where(ingredient => !ingredientsToRemove.Contains(ingredient));
            var updatedFoods = problem.Foods.Select(food => new Food(
                food.Ingredients.Where(ingredient => !ingredientsToRemove.Contains(ingredient)),
                food.Allergens));
            return new Problem(updatedFoods, updatedIngredients, problem.Allergens);
        }
    }
}