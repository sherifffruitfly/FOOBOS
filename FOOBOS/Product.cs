//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FOOBOS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.OrderLines = new HashSet<OrderLine>();
            this.ProductLocations = new HashSet<ProductLocation>();
        }
    
        public int pkid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> ProductCategoryID { get; set; }
        public Nullable<int> UOMID { get; set; }
        public Nullable<double> AvgValue { get; set; }
        public Nullable<double> WarningQty { get; set; }
        public Nullable<System.DateTime> ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderLine> OrderLines { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual UOM UOM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductLocation> ProductLocations { get; set; }
    }
}
