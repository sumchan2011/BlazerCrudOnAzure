using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD1.Entities
{
    public class Store:Base
    {
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
        public string StoreAddress2 { get; set; }
        public string StoreAddress3 { get; set; }
        public string StoreLocalPhone { get; set; }
        public string StoreMobilePhone { get; set; }
        public string StoreFax { get; set; }
        public string StoreBANKAC1 { get; set; }
        public string StoreBANKAC2 { get; set; }
        public string StoreBANKAC3 { get; set; }
        public string StoreEmail { get; set; }
        public int StoreUnit { get; set; }
        public string StoreItemPerPage { get; set; }
        public int StoreLanguage { get; set; }
    }
}
