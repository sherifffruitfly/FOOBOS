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
    
    public partial class UserLog
    {
        public int pkid { get; set; }
        public Nullable<int> ContactID { get; set; }
        public Nullable<System.DateTime> LoginTime { get; set; }
        public Nullable<System.DateTime> LogoutTime { get; set; }
    
        public virtual Contact Contact { get; set; }
    }
}
