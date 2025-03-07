//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcInventorySystemProject.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Tbl_Customers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Customers()
        {
            this.Tbl_Sales = new HashSet<Tbl_Sales>();
        }
    
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Enter the customer name.")]
        [StringLength(50, ErrorMessage = "You can enter a name of up to 50 characters..")]
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Sales> Tbl_Sales { get; set; }
    }
}
