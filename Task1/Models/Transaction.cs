//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int ID { get; set; }
        public Nullable<int> BioId { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public string Entry_Type { get; set; }
        public Nullable<decimal> Need_Amount { get; set; }
        public string Reason { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Master Master { get; set; }
    }
}
