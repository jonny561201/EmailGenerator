﻿using System;
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

        [Test]
        public void CustomerInfoContainsAddress()
        {
            CustomerInfo customer = new CustomerInfo(address:"123 Fake St.");
            Assert.AreEqual("123 Fake St.", customer.CustomerAddress());
        }

        [Test]
        public void CustomerInfoContainsPhoneNumber()
        {
            CustomerInfo customer = new CustomerInfo(phone:"5555153650");
            Assert.AreEqual("5555153650",customer.CustomerPhone());
        }
    }
}
