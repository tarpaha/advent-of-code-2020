using System;
using System.Linq;
using NUnit.Framework;

namespace day_2020_12_03.tests
{
    public class ParserTests
    {
        [Test]
        public void Parse_Works_Correctly()
        {
            var source = new [,]
            {
                { false, false, true,  true  },
                { true,  false, false, false },
                { false, true,  false, false }
            };

            var data = string.Join(
                Environment.NewLine,
                Enumerable.Range(0, source.GetLength(0)).Select(row =>
                {
                    return new string(Enumerable.Range(0, source.GetLength(1))
                        .Select(col => source[row, col])
                        .Select(cell => cell ? '#' : '.')
                        .ToArray());
                })
            );
            
            Assert.That(Parser.Parse(data), Is.EquivalentTo(source));
        }
    }
}