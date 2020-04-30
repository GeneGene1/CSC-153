using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLibrary
{
    public class PreferredCustomer: Customer
    {
        // Fields
        private string _purchase;
        private string _discount;

        // Constructors
        public PreferredCustomer()
        {
            Name = "";
            Purchase = "";
            Discount = "";
        }
        public PreferredCustomer(string name, string purchase, string discount): base(name)
        {
            Name = name;
            Purchase = purchase;
            Discount = discount;
        }

        // Properties
        public string Purchase
        {
            get
            {
                return _purchase;
            }
            set
            {
                _purchase = value;
            }
        }
        public string Discount
        {
            get
            {
                return _discount;
            }
            set
            {
                _discount = value;
            }
        }

        // Methods
        //public override string MadePurchase()
        //{
        //    int purchase = 2000;

        //    if (purchase <= 500)
        //    {
        //        return "5 percent discount";
        //    }
        //    else if (purchase <= 1000)
        //    {
        //        return "6 percent discount";
        //    }
        //    else if (purchase <= 1500)
        //    {
        //        return "7 percent discount";
        //    }
        //    else (purchase >= 2000)
        //    {
        //        return "10 percent discount";
        //    }
        //}
    }
}
