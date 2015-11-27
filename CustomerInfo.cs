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
        private string customerAddress { get; set; }
        private string customerPhone { get; set; }

        public CustomerInfo(string firstName ="", string email = "", string lastName = "", string address = "", string phone = "")
        {
            customerFirstName = firstName;
            customerEmail = email;
            customerLastName = lastName;
            customerAddress = address;
            customerPhone = phone;
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

        internal object CustomerAddress()
        {
            return customerAddress;
        }

        internal object CustomerPhone()
        {
            return customerPhone;
        }
    }
}
