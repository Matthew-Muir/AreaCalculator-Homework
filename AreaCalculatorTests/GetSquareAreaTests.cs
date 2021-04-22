using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculator;

namespace AreaCalculatorTests
{

    [TestClass]
    public class GetSquareAreaTests : TestBase
    {
        


        [TestMethod]
        public void GetSquareArea_PassNumString_ReturnArea()
        {
            CreateNumWordStrings();

            Assert.IsTrue(Calculator.GetSquareArea(_stringOne) == 1);
            Assert.IsTrue(Calculator.GetSquareArea(_stringTwo) == 4);
            Assert.IsTrue(Calculator.GetSquareArea(_stringThree) == 9);
            Assert.IsTrue(Calculator.GetSquareArea(_stringFour) == 16);
            Assert.IsTrue(Calculator.GetSquareArea(_stringFive) == 25);
            Assert.IsTrue(Calculator.GetSquareArea(_stringSix) == 36);
            Assert.IsTrue(Calculator.GetSquareArea(_stringSeven) == 49);
            Assert.IsTrue(Calculator.GetSquareArea(_stringEight) == 64);
            Assert.IsTrue(Calculator.GetSquareArea(_stringNine) == 81);
            Assert.IsTrue(Calculator.GetSquareArea(_stringTen) == 100);

        }

        [TestMethod]
        public void GetSquareArea_PassInvalidString_ReturnNegOne()
        {
            CreateFailingStrings();
            Assert.IsTrue(Calculator.GetSquareArea(_invalidInputString) == -1);
            Assert.IsTrue(Calculator.GetSquareArea(_emptyString) == -1);
            Assert.IsTrue(Calculator.GetSquareArea(_whiteSpaceString) == -1);
        }

    }
}
