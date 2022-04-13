using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    [Table("Lop")]
    public partial class Lop
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string? TenLop { get; set; }

    }
}
