//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Offer_Service
    {
        public int id_offer { get; set; }
        public string service { get; set; }
    
        public virtual Offer Offer { get; set; }
        public virtual Offer Offer1 { get; set; }
        public virtual Service Service1 { get; set; }
        public virtual Service Service2 { get; set; }
    }
}
