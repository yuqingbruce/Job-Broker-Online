//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Job_Broker_Online.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobInformation
    {
        public int Id { get; set; }
        public string JobPosition { get; set; }
        public string CompanyName { get; set; }
        public string WorkAddress { get; set; }
        public string JobDescription { get; set; }
        public string JobRequirement { get; set; }
        public string ContactNumber { get; set; }
        public string ContactEmail { get; set; }
        public string OtherNotes { get; set; }
        public string PersonToContact { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
