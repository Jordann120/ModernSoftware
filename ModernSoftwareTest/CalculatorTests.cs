using ModernSoftwareApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernSoftwareTest
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            var calc = new Calculator();
            Assert.Equal(5, calc.Add(2, 3));
        }

    }
}
