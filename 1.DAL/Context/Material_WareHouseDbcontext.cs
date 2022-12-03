using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.Context
{
    public class MaterialWarehouseDbContext : DbContext
    {
        public MaterialWarehouseDbContext()
        {

        }

        public MaterialWarehouseDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
<<<<<<< HEAD:1.DAL/Context/Material_WareHouseDbcontext.cs
            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=MaterialWarehouseManagementProj;Persist Security Info=True;User ID=huydhph27011;Password=666888");
=======
            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=MaterialWarehouseManagementProj;Persist Security Info=True;User ID=PH26922;Password=tri01637126999");
>>>>>>> 9deba97ab4328dbfc52139d80d82547d0dbbf116:1.DAL/Context/MaterialWarehouseDbContext.cs
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BillDetail>().HasKey(e => new { e.IdMaterial, e.IdBill });
        }
        public DbSet<Bill> bills { get; set; }
        public DbSet<BillDetail> billDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<MaterialDetail> MaterialDetails { get; set; }
        public DbSet<Position> positions { get; set; }
        public DbSet<Producer> producers { get; set; }
        public DbSet<Staff> staffs { get; set; }
        public DbSet<WareHouse> wareHouses { get; set; }
        public DbSet<Account> accounts { get; set; }
        public DbSet<PointsFund> pointsFunds { get; set; }
        public DbSet<PointWallet> pointWallets { get; set; }
        public DbSet<HistoryUsingPoints> HPoints { get; set; }
    }
}