using System;
using System.Data;

namespace BlazorCRUD1.Models
{
    public class StockModel : BaseModel
    {
        public int ProductID { get; set; }

        public double StockCost { get; set; }

        public double StockQty { get; set; }

        //update each stock QTY
        public Boolean isUpdated { get; set; }

    }
}
