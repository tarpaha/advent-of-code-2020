using System.Collections.Generic;
using System.Linq;

namespace day_2020_12_21
{
    public class Food
    {
        public IEnumerable<Ingredient> Ingredients { get; }
        public IEnumerable<Allergen> Allergens { get; }

        public Food(IEnumerable<Ingredient> ingredients, IEnumerable<Allergen> allergens)
        {
            Ingredients = ingredients.ToList();
            Allergens = allergens.ToList();
        }

        public override string ToString()
        {
            return $"{string.Join(" ", Ingredients.Select(i => i.Name))} (contains {string.Join(", ", Allergens.Select(a => a.Name))})";
        }
    }
}