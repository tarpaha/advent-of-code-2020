using System.Collections.Generic;
using NUnit.Framework;

namespace day_2020_12_21.tests
{
    public class ParserTests
    {
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