using BlazorCRUD1.Entities;
using System;
using System.Data;

namespace BlazorCRUD1.Models
{
    public class OrderModel : BaseModel
    {
        //Each txn item
        public int OrderTxnType { get; set; }

        public Customer OrderCustomer { get;set; }

        //System calculate amount
        public double OrderTotalTxn { get; set; }

        //Customer total should amount
        public double OrderNetAmt { get; set; }

        //Customer deposite
        public double OrderDepositAmt { get; set; }
    }
}