using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCRUD1.Entities
{
    public class Stock : Base
    {
        public int ProductID { get; set; }

        public double StockCost { get; set; }

        public double StockQty { get; set; }

        public Boolean isUpdated { get; set; }
    }
}
