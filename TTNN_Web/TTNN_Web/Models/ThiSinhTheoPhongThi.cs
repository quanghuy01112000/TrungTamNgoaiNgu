//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TTNN_Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThiSinhTheoPhongThi
    {
        public int MaThiSinh { get; set; }
        public int MaPhongThi { get; set; }
        public string SBD { get; set; }
        public Nullable<int> DiemNghe { get; set; }
        public Nullable<int> DiemNoi { get; set; }
        public Nullable<int> DiemDoc { get; set; }
        public Nullable<int> DiemViet { get; set; }
    
        public virtual PhongThi PhongThi { get; set; }
        public virtual ThiSinh ThiSinh { get; set; }
    }
}
