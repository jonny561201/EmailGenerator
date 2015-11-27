using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailGenerator
{
    class CustomerInfo
    {
        private string customerName { get; set;}
        private string customerEmail { get; set; }

        public CustomerInfo(string name ="", string email = "")
        {
            customerName = name;
            customerEmail = email;
        }

        public string CustomerName()
        {
            return customerName;
        }

        public string CustomerEmail()
        {
            return customerEmail;
        }
    }
}
