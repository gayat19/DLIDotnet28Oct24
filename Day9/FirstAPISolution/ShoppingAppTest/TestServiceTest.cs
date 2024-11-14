using FirstAPiApp.Interfaces;
using FirstAPiApp.Services;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppTest
{
    public class TestServiceTest
    {
        FirstAPiApp.Interfaces.ITest test;
        [SetUp]
        public void SetUp()
        {
            test = new TestService();
        }

        [Test]
        [TestCase(100,200,300)]
        [TestCase(300, 2147483647, -2147483347)]
        public void AddTest(int n1,int n2,int result)
        {
            //arrange
            //int num1 = 100, num2 = 200;

            //action
            var actualResult = test.Add(n1, n2);

            //assert
            //Assert.AreEqual(301, result);
            Assert.That(actualResult, Is.EqualTo(result));
        }
    }
}
