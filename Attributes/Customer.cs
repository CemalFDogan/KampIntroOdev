using System;
using System.Collections.Generic;
using System.Text;

namespace Attributes
{
    [ToTable("Customers")]
    [ToTable("TblCustomers")]
    public class Customer
    {
        public int Id { get; set; }        
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }
}
