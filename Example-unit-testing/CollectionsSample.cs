using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_unit_testing
{
    public class Customer
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
    public class CollectionsSample
    {

        public static Customer GetCustomer(Customer[] customers, int index)
        {

            return customers[index];

        }

    }
}
