using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Models
{
    public class CustomerModel
    {
        public CustomerModel()
        {
            Customers.Add(new CustomerModel
            {
                CustomerId = 1,
                CustomerName = "Tom"
            });

            Customers.Add(new CustomerModel
            {
                CustomerId = 2,
                CustomerName = "Sarah"
            });

            Customers.Add(new CustomerModel
            {
                CustomerId = 3,
                CustomerName = "Geoff"
            });

        }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public List<CustomerModel> Customers { get; set; }
    }
}
