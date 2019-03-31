using System;
using CPRG214.Assets.Domain;
using Microsoft.EntityFrameworkCore;

namespace CPRG214.Assets.Data
{
    public class AssetsContext: DbContext
    {
        // constructor
        public AssetsContext():base(){ }
        // collection of domain object
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
        // 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\sqlexpress; Database=TechAssets; Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed data created here
            modelBuilder.Entity<AssetType>().HasData(
                new AssetType { Id = 1,  Name = "Monitor"},
                new AssetType { Id = 2, Name = "Phone"},
                new AssetType { Id = 3, Name = "Computer"}
                );

            modelBuilder.Entity<Asset>().HasData(
                new Asset
                {
                    Id = 1,
                    AssetTypeId = 1,
                    Manufacturer = "LG",
                    Model = "LG-M2M",
                    TagNumber = "M2M-24",
                    SerialNumber = "MLST-2245",
                    Description = "Second generation of M2M series monitor."
                },
                new Asset
                {
                    Id = 2,
                    AssetTypeId = 2,
                    Manufacturer = "Apple",
                    Model = "iPhone Xs Max",
                    TagNumber = "Xs-Max",
                    SerialNumber = "XAIT-10101",
                    Description = "Tenth generation of iPhone."
                },
                new Asset
                {
                    Id = 3,
                    AssetTypeId = 3,
                    Manufacturer = "Microsoft",
                    Model = "Surface Pro5",
                    TagNumber = "LMSF-275",
                    SerialNumber = "LMSF-2755",
                    Description = "Fifth generation of Surface line."
                }
                );
            
        }


    }
}
