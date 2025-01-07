using CalculatorLib;

namespace CalculatorLibUnitTests
{
    public class CalculatorUnitTests
    {
        [Fact]
        public void TestAdding2And2()
        {
            // Arrange: input values
            double a = 2;
            double b = 2;
            double expected = 4;
            Calculator calc = new();

            // Act - k�r metoden som ska testas
            double actual = calc.Add(a, b);

            //Assert : kontrollera att resultatet �r korrekt, j�mf�r med f�rv�ntat v�rde
            Assert.Equal(expected, actual);       
        }

        [Fact]
        public void TestAdding2And3() 
        {
            double a = 2;
            double b = 3;
            double expected = 5;
            Calculator calc = new();

            double actual = calc.Add(a, b);

            Assert.Equal(expected, actual);
        }
    }
}