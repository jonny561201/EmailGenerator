using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailGenerator
{
    class CustomerInfo
    {
        private string customerFirstName { get; set;}
        private string customerEmail { get; set; }
        private string customerLastName { get; set; }

        public CustomerInfo(string firstName ="", string email = "", string lastName = "")
        {
            customerFirstName = firstName;
            customerEmail = email;
            customerLastName = lastName;
        }

        public string CustomerFirstName()
        {
            return customerFirstName;
        }

        public string CustomerEmail()
        {
            return customerEmail;
        }

        public string CustomerLastName()
        {
            return customerLastName;
        }
    }
}
