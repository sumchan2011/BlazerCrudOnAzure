using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCRUD1.Entities
{
    public class Order : Base
    {
        public int OrderTxnType { get; set; }

        public Customer OrderCustomer { get; set; }

        public double OrderTotalTxn { get; set; }

        public double OrderDiscountAmt { get; set; }

        public double OrderNetAmt { get; set; }

        public double OrderDepositAmt { get; set; }

    }
}
