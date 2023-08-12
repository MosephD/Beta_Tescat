﻿// <auto-generated />
using System;
using Beta_Tescat_0._1.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Beta_Tescat_0._1.Persistence.Data.Migrations
{
    [DbContext(typeof(TescatContext))]
    partial class TescatContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Beta_Tescat_0._1.Persistence.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Entry_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Last_Modif")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Last_Working_Date")
                        .HasColumnType("datetime2");

                    b.Property<long>("Mobile")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Office")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telephone")
                        .HasColumnType("int");

                    b.Property<bool>("Web_Privileges")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Department = "Administracion",
                            Entry_Date = new DateTime(2003, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Last_Modif = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Last_Working_Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Mobile = 6641754655L,
                            Name = "Itzel Ameyalli Castro Castillo",
                            Office = "Ensenada",
                            Position = "Cuenta de Gastos",
                            Telephone = 106,
                            Web_Privileges = true
                        },
                        new
                        {
                            Id = 2,
                            Department = "Administracion",
                            Entry_Date = new DateTime(2016, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Last_Modif = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Last_Working_Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Mobile = 6469472236L,
                            Name = "Marco Antonio Ramirez Perez",
                            Office = "Tijuana",
                            Position = "Comercializacion",
                            Telephone = 133,
                            Web_Privileges = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
