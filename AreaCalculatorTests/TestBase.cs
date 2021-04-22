using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaCalculatorTests
{
    public class TestBase
    {
        public TestContext TestContext { get; set; }

        //strings for testing error handling of GetSquareArea
        protected string _emptyString;
        protected string _whiteSpaceString;
        protected string _invalidInputString;

        //strings for testing GetSquareArea
        public string _stringOne;
        protected string _stringTwo;
        protected string _stringThree;
        protected string _stringFour;
        protected string _stringFive;
        protected string _stringSix;
        protected string _stringSeven;
        protected string _stringEight;
        protected string _stringNine;
        protected string _stringTen;

        //Values for testing GetParallelogramArea

        protected double _height;
        protected double _length;

        protected double _invalidHeight;
        protected double _invalidLength;
        protected double _tooLargeOfValue;

        public void CreateNumWordStrings()
        {
            _stringOne = TestContext.Properties["stringOne"].ToString();
            _stringTwo = TestContext.Properties["stringTwo"].ToString();
            _stringThree = TestContext.Properties["stringThree"].ToString();
            _stringFour = TestContext.Properties["stringFour"].ToString();
            _stringFive = TestContext.Properties["stringFive"].ToString();
            _stringSix = TestContext.Properties["stringSix"].ToString();
            _stringSeven = TestContext.Properties["stringSeven"].ToString();
            _stringEight = TestContext.Properties["stringEight"].ToString();
            _stringNine = TestContext.Properties["stringNine"].ToString();
            _stringTen = TestContext.Properties["stringTen"].ToString();
        }

        public void CreateFailingStrings()
        {
            _emptyString = TestContext.Properties["emptyString"].ToString();
            _whiteSpaceString = TestContext.Properties["whiteSpaceString"].ToString();
            _invalidInputString = TestContext.Properties["invalidInputString"].ToString();

        }
        
        public void CreateValidLengthAndHeightValues()
        {
            _length = double.Parse(TestContext.Properties["validLength"].ToString());
            _height = double.Parse(TestContext.Properties["validHeight"].ToString());
        }

        public void CreateInvalidHeightAndLengthValues()
        {
            _invalidHeight = double.Parse(TestContext.Properties["invalidHeight"].ToString());
            _invalidLength = double.Parse(TestContext.Properties["invalidLength"].ToString());
            
        }
    }
}
