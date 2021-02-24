using System.Linq;
using System.Collections.Generic;

namespace day_2020_12_21
{
    public class Problem
    {
        public IEnumerable<Food> Foods { get; }
        public IEnumerable<Ingredient> Ingredients { get; }
        public IEnumerable<Allergen> Allergens { get; }

        public Problem(IEnumerable<Food> foods, IEnumerable<Ingredient> ingredients, IEnumerable<Allergen> allergens)
        {
            Foods = foods.ToHashSet();
            Ingredients = ingredients.ToHashSet();
            Allergens = allergens.ToHashSet();
        }
    }
}