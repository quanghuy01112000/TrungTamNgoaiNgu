﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Service.DTOs
{
    public class HdNhapDTO : BaseDTO
    {
        [Required]
        public int TaiKhoanId { get; set; }

        [Required]
        public int NccId { get; set; }

        [DefaultValue(0)]
        [Required]
        public decimal TongTien { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime NgayTao { get; set; }

        public ICollection<CtNhapDTO> ChiTietNhaps { get; set; }
    }
}
