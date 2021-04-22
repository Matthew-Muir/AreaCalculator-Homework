using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreaCalculator;

namespace AreaCalculatorTests
{
    [TestClass]
    public class GetParallelogramAreaTests : TestBase
    {
        [TestMethod]
        public void GetParallelogramArea_PassValidHeightAndLength_ReturnArea()
        {
            CreateValidLengthAndHeightValues();
            Assert.IsTrue(Calculator.GetParallelogramArea(_height, _length) == 2);
        }

        [TestMethod]
        public void GetParallelogramArea_PassInvalidHeightAndLength_ReturnNegOne()
        {
            CreateInvalidHeightAndLengthValues();
            Assert.IsTrue(Calculator.GetParallelogramArea(_invalidHeight, _length) == -1);
            Assert.IsTrue(Calculator.GetParallelogramArea(_height, _invalidLength) == -1);
            Assert.IsTrue(Calculator.GetParallelogramArea(_invalidHeight, _invalidLength) == -1);



        }



    }
}
