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
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.JobInformations = new HashSet<JobInformation>();
        }
    
        public string AccountName { get; set; }
        public string Password { get; set; }
        public string CompanyName { get; set; }
        public string PersonToConract { get; set; }
        public string ContactNumber { get; set; }
        public string ContactEmail { get; set; }
        public string CompanyAddress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobInformation> JobInformations { get; set; }
    }
}
