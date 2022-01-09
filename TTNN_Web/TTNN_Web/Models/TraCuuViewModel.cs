using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TTNN_Web.Models
{
    public class TraCuuViewModel
    {
        public string TenThiSinh { get; set; }
        public string MaThiSinh { get; set; }
        public string SoDienThoai { get; set; }
        public string SBD { get; set; }
        public string TenPhongThi { get; set; }
        public int DiemNghe { get; set; }
        public int DiemNoi { get; set; }
        public int DiemViet { get; set; }
        public int DiemDoc { get; set; }

        public bool Emtpy()
        {
            return true;
        }
    }
}