//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class payments
    {
        public int customerNumber { get; set; }
        public string checkNumber { get; set; }
        public System.DateTime paymentDate { get; set; }
        public double amount { get; set; }
    
        public virtual customers customers { get; set; }
    }
}
