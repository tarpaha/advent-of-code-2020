using System.Collections.Generic;
using System.Linq;

namespace day_2020_12_21
{
    public class Food
    {
        private readonly List<Ingredient> _ingredients;
        private readonly List<Allergen> _allergens;

        public Food(List<Ingredient> ingredients, List<Allergen> allergens)
        {
            _ingredients = ingredients;
            _allergens = allergens;
        }

        public override string ToString()
        {
            return $"{string.Join(" ", _ingredients.Select(i => i.Name))} (contains {string.Join(", ", _allergens.Select(a => a.Name))})";
        }
    }
}