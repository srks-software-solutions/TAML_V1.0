//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace i_facility.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblmachineallocation
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> MachineID { get; set; }
        public Nullable<int> ShiftID { get; set; }
        public string CorrectedDate { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    
        public virtual tblmachinedetail tblmachinedetail { get; set; }
        public virtual tblshift_mstr tblshift_mstr { get; set; }
        public virtual tbluser tbluser { get; set; }
    }
}
