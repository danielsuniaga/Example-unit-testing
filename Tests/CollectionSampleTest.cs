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
    public class CollectionSampleTest
    {

        [TestMethod]
        public void GetCustomer_ShouldGetSameCustomer()
        {

            //Arrange

            Customer[] customers = new Customer[2] {

                new Customer {FirstName = "John", LastName ="Ford"},

                new Customer {FirstName = "Billy", LastName ="Wilder"},

            };

            int index = 1;

            Customer expect = customers[1];

            //Act

            Customer actual = CollectionsSample.GetCustomer(customers, index);



            // Assert

            Assert.IsInstanceOfType(actual, typeof(Customer));

            Assert.AreEqual(expect, actual);

        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetCustomer_ShouldThrowIndexOutiofRangeException()
        {
            //Arrange

            Customer[] customers = new Customer[2] {

                new Customer {FirstName = "John", LastName ="Ford"},

                new Customer {FirstName = "Billy", LastName ="Wilder"},

            };

            int index = 3;

            Customer expect = customers[1];

            //Act

            CollectionsSample.GetCustomer(customers, index);

            //Assert
        }

    }
}
