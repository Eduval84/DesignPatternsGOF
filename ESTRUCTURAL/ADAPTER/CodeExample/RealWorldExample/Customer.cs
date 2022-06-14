using System.Collections.Generic;

namespace RealWorldExample
{
    public class Customer
    {
        public string Name { get; private set; }
        public string City { get; private set; }
        public string Address { get; private set; }

        public static List<Customer> GetData() =>
            new List<Customer>
            {
                new Customer { City = "Italy", Name = "Alfa Romeo", Address = "AddressItaly" },
                new Customer { City = "UK", Name = "Aston Martin", Address = "AddressUK"  },
                new Customer { City = "USA", Name = "Dodge", Address = "AddressUSA"  },
                new Customer { City = "Japan", Name = "Subaru", Address = "AddressJapan"  },
                new Customer { City = "Germany", Name = "BMW", Address = "AddressGermany"  }
            };
    }
}