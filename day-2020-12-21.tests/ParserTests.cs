using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;

namespace day_2020_12_21.tests
{
    public class ParserTests
    {
        [TestCase(@"
mxmxvkd kfcds sqjhc nhms (contains dairy, fish)
trh fvjkl sbzzf mxmxvkd (contains dairy)
sqjhc fvjkl (contains soy)
sqjhc mxmxvkd sbzzf (contains fish)", 4, 7, 3)]
        public void Parse_Works_Correctly(string data, int foods, int ingredients, int allergens)
        {
            var problem = Parser.Parse(data);
            Assert.That(problem.Foods.Count(), Is.EqualTo(foods));
            Assert.That(problem.Ingredients.Count(), Is.EqualTo(ingredients));
            Assert.That(problem.Allergens.Count(), Is.EqualTo(allergens));
        }
        
        [TestCase("mxmxvkd kfcds sqjhc nhms (contains dairy, fish)")]
        [TestCase("trh fvjkl sbzzf mxmxvkd (contains dairy)")]
        [TestCase("sqjhc fvjkl (contains soy)")]
        [TestCase("sqjhc mxmxvkd sbzzf (contains fish)")]
        public void ParseLine_Works_Correctly(string line)
        {
            var ingredientsDict = new Dictionary<string, Ingredient>();
            var allergensDict = new Dictionary<string, Allergen>();
            Assert.That(Parser.ParseLine(line, ingredientsDict, allergensDict).ToString(), Is.EqualTo(line));
        }
    }
}