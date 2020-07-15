using BlazorCRUD1.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD1.Resources.Utils
{
    public class Utils
    {
        public static Dictionary<string,double> convertStockUnit(double stockInKg, int unitType)
        {
            Dictionary<string, double> unitStock = new Dictionary<string, double>();
            switch (unitType)
            {
                case 0://kg 
                    unitStock["stock"] = stockInKg;
                    return unitStock;
                case 1://chinese
                    double gun = stockInKg/0.6048;
                    unitStock["stock"] = gun;
                    return unitStock;
            }
            return unitStock;
        }
    }
}
