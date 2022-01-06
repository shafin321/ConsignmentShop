using System;
using System.Collections.Generic;
using System.Text;

namespace ConsginementLibrary
{
 public   class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }
        public decimal PaymenttDue { get; set; }
        public string Display { get {

                return $"{FirstName}, {LastName}, {PaymenttDue}";
            } }

       
    }
}
