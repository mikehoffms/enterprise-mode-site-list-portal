//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMIEWebPortal.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Logger
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> LoggedOn { get; set; }
        public string ActionMethod { get; set; }
        public string Description { get; set; }
        public string Operation { get; set; }
        public string ProductCategory { get; set; }
    }
}
