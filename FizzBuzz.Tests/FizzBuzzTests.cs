using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperFizzBuzz;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException), "An incorrect value for Amount is not allowed.")]
        //public void NullAmountInConstructor()
        //{
        //    SuperFB sfb = new SuperFB(null);
        //}

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "An incorrect value for RangeMin is not allowed.")]
        public void NullRangeMinInConstructor()
        {
            SuperFB sfb = new SuperFB(null, 10, "Fizz", "Buzz", "Bazz", 3, 7, 38);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "An incorrect value for RangeMax is not allowed.")]
        public void NullRangeMaxInConstructor()
        {
            SuperFB sfb = new SuperFB(1, null, "Fizz", "Buzz", "Bazz", 3, 7, 38);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "An incorrect value for List is not allowed.")]
        public void NullListInConstructor()
        {
            List<int> list = null;
            SuperFB sfb = new SuperFB(list, "Fizz", "Buzz", "Bazz");
        }

        [TestMethod]
        public void PrintListBasicTest()
        {
            SuperFB sfb = new SuperFB(10);
            sfb.Token1 = "Fizz";
            sfb.Token2 = "Buzz";
            Assert.AreEqual(10, sfb.List.Capacity);
        }

        [TestMethod]
        public void PrintListAdvTest()
        {
            SuperFB sfb = new SuperFB(1, 10, "Fizz", "Buzz", "Bazz", 3, 7, 38);
            Assert.AreEqual(10, sfb.List.Capacity);
        }
    }
}
