using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    [Table("SinhVien")]
    public partial class SinhVien
    {
        [Key]
        public int Id { get; set; }
        [Column("MaSV")]
        [StringLength(10)]
        public string? MaSv { get; set; }
        [StringLength(50)]
        public string? HoTen { get; set; }
        public int? IdLop { get; set; }
    }
}
