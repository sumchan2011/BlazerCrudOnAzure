using System;

namespace BlazorCRUD1.Models
{
    public class BaseModel
    {
        public int ID { get; set; }

        public DateTime UpdatedDateTime { get; set; }

        public string UpdatedBy { get; set; }
    }
}
