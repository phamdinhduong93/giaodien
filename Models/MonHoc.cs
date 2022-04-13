using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    [Table("MonHoc")]
    public partial class MonHoc
    {
        [Key]
        public int Id { get; set; }
        public string? TenMonHoc { get; set; }
    }
}
