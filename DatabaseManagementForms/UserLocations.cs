//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseManagementForms
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserLocations
    {
        public string UserID { get; set; }
        public System.Guid LocationID { get; set; }
        public int TotalVisitations { get; set; }
        public System.DateTime FirstVisited { get; set; }
        public System.DateTime LastVisited { get; set; }
    
        public virtual Locations Locations { get; set; }
        public virtual Users Users { get; set; }
    }
}
