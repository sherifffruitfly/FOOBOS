//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FOOBOSEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class SaleLog
    {
        public int pkid { get; set; }
        public Nullable<int> SaleID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<System.DateTime> SaleDate { get; set; }
        public Nullable<int> SaleLineID { get; set; }
        public Nullable<int> SaleLineSaleID { get; set; }
        public Nullable<int> ProductLocationID { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public Nullable<double> Qty { get; set; }
        public string Description { get; set; }
        public string ChangeType { get; set; }
        public Nullable<System.DateTime> ChangeTime { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual Contact Contact { get; set; }
    }
}
