//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebsiteGiay.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HINHSP
    {
        public int MaHinh { get; set; }
        public Nullable<int> MaGiay { get; set; }
        public string TenHinh { get; set; }
    
        public virtual GIAY GIAY { get; set; }
    }
}
