using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TestNinja.Fundamentals;
namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        CustomerController _customerController;

        [SetUp]
        public void Setup()
        {
            _customerController = new CustomerController();
        }
        
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            // TypeOf is for exactly this type, InstanceOf would give true for this type and its derivatives
            Assert.That(_customerController.GetCustomer(0), Is.TypeOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnNotFound()
        {
            Assert.That(_customerController.GetCustomer(1), Is.TypeOf<Ok>());
        }
    }
}
