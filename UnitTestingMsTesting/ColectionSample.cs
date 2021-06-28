using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingMsTesting
{
    public class Customer
    {
        public string FirstName { get; set; }

        public string LasttName { get; set; }
    }
     
    public class CollectionsSample
    {
        public static Customer GetCustomer(Customer[] customer , int index)
        {
            return customer[index];
        }
    }
    
}
