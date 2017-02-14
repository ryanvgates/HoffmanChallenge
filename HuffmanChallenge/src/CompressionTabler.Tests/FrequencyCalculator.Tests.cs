using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CompressionTabler.Tests
{
    public class FrequencyCalculatorTests
    {
        [Fact]
        public void GetFrequency_HappyPath_Test()
        {
            // Arrange
            var input = @"9407c2f7-4fab-4181-9d4e-cb87ca663a82
cbaaf903-0935-4805-b23c-1429b1782bc4";
            var expected = new Dictionary<string, int>
            {
                {"-", 8},
                {"0", 4},
                {"1", 4},
                {"2", 5},
                {"3", 4},
                {"4", 7},
                {"5", 2},
                {"6", 2},
                {"7", 4},
                {"8", 5},
                {"9", 5},
                {"a", 5},
                {"b", 6},
                {"c", 6},
                {"d", 1},
                {"e", 1},
                {"f", 3},
            };
            // Act
            var actual = new FrequencyCalculator().GetFrequency(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
