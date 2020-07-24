using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCRUD1.Entities
{
    public class SaleTxn : Base
    {
        public Product SaleProduct { get; set; }

        public int SaleTxnProductID { get; set; }

        public int SaleTxnStatus { get; set; }

        public double SaleTxnQty{ get; set; }

        public double SaleSubTotal { get; set; } = 0.0;

        public List<Stock> ProductStock { get; set; }

        public int SaleTxnOrderID { get; set; }

        public double SaleReceivedQty { get; set; }

        public double CalculateSubTotal()
        {
            this.SaleSubTotal = this.SaleTxnQty * this.SaleProduct.ProductPrice;
            return this.SaleSubTotal;
        }

        public void checkQtyToSale()
        {
            if (SaleTxnQty > 100)
                SaleTxnStatus = 1;
            else
                SaleTxnStatus = 0;
        }

    }
}
