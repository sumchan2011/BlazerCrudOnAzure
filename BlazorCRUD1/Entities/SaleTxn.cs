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

        public int SaleStatus { get; set; }

        public double SaleQty{ get; set; }

        public double SaleSubTotal { get; set; } = 0.0;

        public List<Stock> ProductStock { get; set; }

        public int SaleTxnOrderID { get; set; }

        public double SaleRemainQty { get; set; }

        public double CalculateSubTotal()
        {
            this.SaleSubTotal = this.SaleQty * this.SaleProduct.ProductPrice;
            return this.SaleSubTotal;
        }

        public void checkQtyToSale()
        {
            if (SaleQty > 100)
                SaleStatus = 1;
            else
                SaleStatus = 0;
        }

    }
}
