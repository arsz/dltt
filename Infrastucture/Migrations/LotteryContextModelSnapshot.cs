// <auto-generated />
using System;
using Infrastucture.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastucture.Migrations
{
    [DbContext(typeof(LotteryContext))]
    partial class LotteryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Core.Entities.DrawHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("FifthNumber")
                        .HasColumnType("int");

                    b.Property<int>("FirstNumber")
                        .HasColumnType("int");

                    b.Property<int>("FourthNumber")
                        .HasColumnType("int");

                    b.Property<int>("SecondNumber")
                        .HasColumnType("int");

                    b.Property<int>("ThirdNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DrawHistories");
                });
#pragma warning restore 612, 618
        }
    }
}
