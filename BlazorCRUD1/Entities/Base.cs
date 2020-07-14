using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorCRUD1.Entities
{
    public class Base
    {
        [Key]
        public int ID { get; set; }

        public DateTime UpdatedDateTime { get; set; }

        public string UpdatedBy { get; set; }
    }
}
