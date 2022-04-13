using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication2.Models
{
    public partial class SinhVienContext : DbContext
    {
        public SinhVienContext()
        {
        }

        public SinhVienContext(DbContextOptions<SinhVienContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Lop> Lops { get; set; } = null!;
        public virtual DbSet<SinhVien> SinhViens { get; set; } = null!;
        public virtual DbSet<MonHoc> MonHocs { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQL2019;Database=SinhVien;User id=sa; password=123456;");
            }
        }

        public DataTable ExcuteSqlDataTable(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlConnection cnn = (SqlConnection)this.Database.GetDbConnection();
                DbDataAdapter sa = new SqlDataAdapter(sql, cnn);
                sa.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lop>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<MonHoc>();

            modelBuilder.Entity<SinhVien>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.MaSv).IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
