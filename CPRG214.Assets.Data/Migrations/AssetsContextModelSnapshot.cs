﻿// <auto-generated />
using CPRG214.Assets.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CPRG214.Assets.Data.Migrations
{
    [DbContext(typeof(AssetsContext))]
    partial class AssetsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CPRG214.Assets.Domain.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssetTypeId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Manufacturer")
                        .IsRequired();

                    b.Property<string>("Model");

                    b.Property<string>("SerialNumber")
                        .IsRequired();

                    b.Property<string>("TagNumber")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AssetTypeId");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("CPRG214.Assets.Domain.AssetType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("AssetTypes");
                });

            modelBuilder.Entity("CPRG214.Assets.Domain.Asset", b =>
                {
                    b.HasOne("CPRG214.Assets.Domain.AssetType", "AssetType")
                        .WithMany("Assets")
                        .HasForeignKey("AssetTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
