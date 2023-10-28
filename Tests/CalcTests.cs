using Example_unit_testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{

    [TestClass]

    public class CalcTests
    {

        [DataRow(4, 4, 8)]
        [DataRow(5, 5, 10)]
        [DataRow(24, 26, 50)]
        [DataRow(24, 26, 40)]

        [TestMethod]
        public void Sum_ShouldCalcAndReturnSameValue(int a, int b, int expected)
        {
            //Arrange

            //Act

            int actual = Calcs.Sum(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
