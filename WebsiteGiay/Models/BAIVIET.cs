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
    
    public partial class BAIVIET
    {
        public int MaBV { get; set; }
        public string NoiDung { get; set; }
        public Nullable<int> MaHinh { get; set; }
        public string MaNV { get; set; }
    
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
