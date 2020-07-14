using System.ComponentModel.DataAnnotations;

namespace BlazorCRUD1.Entities
{
    public class Product : Base
    {
        public string ProductName { get; set; }

        public string ProductDetails { get; set; }

        public string ProductOrigin { get; set; }

        public double ProductPrice { get; set; }

        public double ProductTotalStock { get; set; }

    }
}
