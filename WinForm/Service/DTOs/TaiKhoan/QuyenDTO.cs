﻿using System.ComponentModel.DataAnnotations;

namespace Service.DTOs
{
    public class QuyenDTO : BaseDTO
    {
        [StringLength(20)]
        [Required]
        public string TenQuyen { get; set; }

        [StringLength(60)]
        public string MoTa { get; set; }
    }
}
