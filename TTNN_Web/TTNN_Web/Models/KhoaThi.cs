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
    
    public partial class KhoaThi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhoaThi()
        {
            this.PhongThis = new HashSet<PhongThi>();
            this.ThiSinhCuaKhoaThis = new HashSet<ThiSinhCuaKhoaThi>();
        }
    
        public int MaKhoaThi { get; set; }
        public string TenKhoaThi { get; set; }
        public Nullable<System.DateTime> NgayThi { get; set; }
        public string TrangThai { get; set; }
        public Nullable<int> PhongB1ToiDa { get; set; }
        public Nullable<int> PhongA2ToiDa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhongThi> PhongThis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThiSinhCuaKhoaThi> ThiSinhCuaKhoaThis { get; set; }
    }
}
