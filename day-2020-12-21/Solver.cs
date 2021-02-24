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
                .Where(ingredient => !problem.Allergens.Any(allergen => IngredientCanContainAllergen(ingredient, allergen)));

            return problem.Foods
                .SelectMany(food => food.Ingredients)
                .Count(ingredient => ingredientWithoutAllergens.Contains(ingredient));
        }
    }
}