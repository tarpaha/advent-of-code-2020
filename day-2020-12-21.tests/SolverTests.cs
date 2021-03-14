using System.Linq;
using NUnit.Framework;

namespace day_2020_12_21.tests
{
    public class SolverTests
    {
        private Problem _problem;
        
        [SetUp]
        public void Init()
        {
            _problem = Parser.Parse(@"
mxmxvkd kfcds sqjhc nhms (contains dairy, fish)
trh fvjkl sbzzf mxmxvkd (contains dairy)
sqjhc fvjkl (contains soy)
sqjhc mxmxvkd sbzzf (contains fish)");
        }

        [TestCase(5)]
        public void Part1(int result)
        {
            Assert.That(Solver.Part1(_problem), Is.EqualTo(result));
        }

        [TestCase("mxmxvkd,sqjhc,fvjkl")]
        public void Part2(string result)
        {
            Assert.That(Solver.Part2(_problem), Is.EqualTo(result));
        }

        [TestCase("kfcds,nhms,sbzzf,trh")]
        public void GetIngredientsWithoutAllergens_Works_Correctly(string result)
        {
            var ingredients = Solver.GetIngredientsWithoutAllergens(_problem);
            var sortedIngredientNames = string.Join(
                ",",
                ingredients
                    .Select(ingredient => ingredient.Name)
                    .OrderBy(name => name)
                );
            Assert.That(sortedIngredientNames, Is.EqualTo(result));
        }
        
        [TestCase("kfcds,nhms,sbzzf,trh", "",
@"mxmxvkd sqjhc (contains dairy, fish)
fvjkl mxmxvkd (contains dairy)
sqjhc fvjkl (contains soy)
sqjhc mxmxvkd (contains fish)")]
        [TestCase("kfcds,nhms,sbzzf,trh", "dairy",
            @"mxmxvkd sqjhc (contains fish)
fvjkl mxmxvkd (contains )
sqjhc fvjkl (contains soy)
sqjhc mxmxvkd (contains fish)")]
        public void MakeProblemWithoutIngredientsAndAllergens_Works_Correctly(string ingredientNamesStr, string allergenNamesStr, string result)
        {
            var ingredientNames = ingredientNamesStr.Split(',').ToHashSet();
            var ingredients = _problem.Ingredients.Where(ingredient => ingredientNames.Contains(ingredient.Name));
            var allergenNames = allergenNamesStr.Split(",").ToHashSet();
            var allergens = _problem.Allergens.Where(allergen => allergenNames.Contains(allergen.Name));
            Assert.That(
                Solver.MakeProblemWithoutIngredientsAndAllergens(_problem, ingredients, allergens).ToString(), Is.EqualTo(result));
        }
    }
}