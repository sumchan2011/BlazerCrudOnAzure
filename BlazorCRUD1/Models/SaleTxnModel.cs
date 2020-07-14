using BlazorCRUD1.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace BlazorCRUD1.Models
{
    public class SaleTxnModel : BaseModel
    {

        public Product SaleProduct { get; set; }

        public int SaleStatus { get; set; }

        public double SaleQty { get; set; }

        public double SaleSubTotal { get; set; }

        public List<Stock> ProductStock { get; set; }

        public double SaleRemainQty { get; set; }
    }
}