/**
 * 4/23/2020
 * CSC 153
 * Eugene Davis-Paulino
 * Creating a customer class from the person class
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Customer: Person
    {
        private string _customerNumber;
        private bool _mailing;

        public Customer()
        {
            CustomerNumber = "";
            Name = "";
            Address = "";
            PhoneNumber = "";
            Mailing = false;
        }
        public Customer(string name, string address, string phoneNumber, string customerNumber, bool mailing): base(name, address, phoneNumber)
        {
            CustomerNumber = customerNumber;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Mailing = mailing;
        }
        public string CustomerNumber
        {
            get
            {
                return _customerNumber;
            }
            set
            {
                _customerNumber = value;
            }
        }
        public bool Mailing
        {
            get
            {
                return _mailing;
            }
            set
            {
                _mailing = value;
            }
        }
    }
}
