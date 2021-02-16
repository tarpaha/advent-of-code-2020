using System;
using System.Collections.Generic;
using System.Linq;

namespace day_2020_12_21
{
    public static class Parser
    {
        public static Food ParseLine(string line, Dictionary<string, Ingredient> ingredientsDict, Dictionary<string, Allergen> allergensDict)
        {
            var parts = line.Split(new[] {'(', ')'}, StringSplitOptions.RemoveEmptyEntries);
            
            var ingredientNames = parts[0].Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var ingredients = new List<Ingredient>();
            foreach (var ingredientName in ingredientNames)
            {
                if (!ingredientsDict.TryGetValue(ingredientName, out var ingredient))
                {
                    ingredient = new Ingredient(ingredientName);
                    ingredientsDict.Add(ingredientName, ingredient);
                }
                ingredients.Add(ingredient);
            }
            
            var allergenNames = parts[1].Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).Skip(1);
            var allergens = new List<Allergen>();
            foreach (var allergenName in allergenNames)
            {
                if (!allergensDict.TryGetValue(allergenName, out var allergen))
                {
                    allergen = new Allergen(allergenName);
                    allergensDict.Add(allergenName, allergen);
                }
                allergens.Add(allergen);
            }

            return new Food(ingredients, allergens);
        }
    }
}