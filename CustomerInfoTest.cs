using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace EmailGenerator
{
    [TestFixture]
    class CustomerInfoTest
    {
        [Test]
        public void CustomerInfoContainFirstName()
        {
            CustomerInfo customer = new CustomerInfo("Test");
            Assert.AreEqual("Test",customer.CustomerFirstName());
        }

        [Test]
        public void CustomerInfoContainEMail()
        {
            CustomerInfo customer = new CustomerInfo(email:"jonny561201@hotmail.com");
            Assert.AreEqual("jonny561201@hotmail.com", customer.CustomerEmail());
        }

        [Test]
        public void CustomerInfoContainsLastName()
        {
            CustomerInfo customer = new CustomerInfo(lastName:"LastName");
            Assert.AreEqual("LastName", customer.CustomerLastName());
        }
    }
}
