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
    
    public partial class UserRoleBPUMapping
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserRoleBPUMapping()
        {
            this.EMIETicketAprovals = new HashSet<EMIETicketAproval>();
        }
    
        public int ID { get; set; }
        public int UserId { get; set; }
        public int BPUId { get; set; }
        public int RoleId { get; set; }
        public Nullable<int> ModifiedById { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> CreatedById { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string MappingDetails { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsRegistered { get; set; }
    
        public virtual BPU BPU { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMIETicketAproval> EMIETicketAprovals { get; set; }
    }
}
