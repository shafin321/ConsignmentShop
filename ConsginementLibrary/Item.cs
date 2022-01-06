using System;
using System.Collections.Generic;
using System.Text;

namespace ConsginementLibrary
{
  public  class Item
    {
        public string Name { get; set; }
        public string Discription { get; set; }
        public decimal Price { get; set; }
        public bool sold { get; set; }
        public bool PaymentDistributed { get; set; }
        //Owner of the ITEM -> Vendor 
        public Vendor Owner { get; set; }

        public string Display { get
            {
                return $"Name {Name}, Price {Price}, Vendor {Owner.FirstName}";

            } }

    }
}
