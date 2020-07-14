using System;
using System.Data;

namespace BlazorCRUD1.Models
{
    public class CustomerModel : BaseModel
    {
        public int CustomerPhone { get; set;}

        public String CustomerName { get; set; }

        public String CustomerCompany { get; set; }

        public String CustomerEmail { get; set; }

    }
}
