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


    }
}
