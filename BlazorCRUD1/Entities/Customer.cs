using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCRUD1.Entities
{
    public class Customer : Base
    {
        public Customer()
        {
            this.CustomerPhone = 99999999;
            this.CustomerName = "Customer";
            this.CustomerCompany = "N/A";
            this.CustomerEmail = "N/A";
        }

        public int CustomerPhone { get; set; }

        public String CustomerName { get; set; }

        public String CustomerCompany { get; set; }

        public String CustomerEmail { get; set; }

    }
}
