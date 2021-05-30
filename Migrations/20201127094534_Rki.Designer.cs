﻿// <auto-generated />
using System;
using BDTransportCompany.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BDTransportCompany.Migrations
{
    [DbContext(typeof(BDTransportCompanyContext))]
    [Migration("20201127094534_Rki")]
    partial class Rki
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BDTransportCompany.Models.Cargos", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Cargo_ID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Features")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("RoutesID")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("TypesOfCargosID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("RoutesID");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("BDTransportCompany.Models.Cars", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BodyNumber")
                        .HasColumnType("int");

                    b.Property<long>("CarBrandID")
                        .HasColumnType("bigint");

                    b.Property<long>("Car_ID")
                        .HasColumnType("bigint");

                    b.Property<int>("EngineNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastMaintenanceDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("PositionID1")
                        .HasColumnType("bigint");

                    b.Property<long>("PositionID2")
                        .HasColumnType("bigint");

                    b.Property<int>("RegistrationNumber")
                        .HasColumnType("int");

                    b.Property<long?>("RoutesID")
                        .HasColumnType("bigint");

                    b.Property<long>("TypeOfCarID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("YearOfIssue")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("RoutesID");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("BDTransportCompany.Models.CarsBrands", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CarBrand_ID")
                        .HasColumnType("bigint");

                    b.Property<long?>("CarsID")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specifications")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CarsID");

                    b.ToTable("CarsBrands");
                });

            modelBuilder.Entity("BDTransportCompany.Models.Positions", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Demands")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Position_ID")
                        .HasColumnType("bigint");

                    b.Property<string>("Responsibilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<long?>("StaffID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("StaffID");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("BDTransportCompany.Models.Routes", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CarID")
                        .HasColumnType("bigint");

                    b.Property<long>("CargoID")
                        .HasColumnType("bigint");

                    b.Property<string>("Customer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfArrival")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfDeparture")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("RecordOfThePayment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("StaffID")
                        .HasColumnType("bigint");

                    b.Property<string>("TheMarkOnTheReturn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Where")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhereFrom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("BDTransportCompany.Models.Staff", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<long?>("CarsID")
                        .HasColumnType("bigint");

                    b.Property<long?>("CarsID1")
                        .HasColumnType("bigint");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PositionID")
                        .HasColumnType("bigint");

                    b.Property<long?>("RoutesID")
                        .HasColumnType("bigint");

                    b.Property<long>("Staff_ID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("CarsID");

                    b.HasIndex("CarsID1");

                    b.HasIndex("RoutesID");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("BDTransportCompany.Models.TypesOfCargos", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CargosID")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("TypeOfCarID")
                        .HasColumnType("bigint");

                    b.Property<long>("TypesOfCargos_ID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("CargosID");

                    b.ToTable("TypesOfCargos");
                });

            modelBuilder.Entity("BDTransportCompany.Models.TypesOfCars", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CarsID")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("TypeofCar_ID")
                        .HasColumnType("bigint");

                    b.Property<long?>("TypesOfCargosID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("CarsID");

                    b.HasIndex("TypesOfCargosID");

                    b.ToTable("TypesOfCars");
                });

            modelBuilder.Entity("BDTransportCompany.Models.Cargos", b =>
                {
                    b.HasOne("BDTransportCompany.Models.Routes", null)
                        .WithMany("Cargo_ID")
                        .HasForeignKey("RoutesID");
                });

            modelBuilder.Entity("BDTransportCompany.Models.Cars", b =>
                {
                    b.HasOne("BDTransportCompany.Models.Routes", null)
                        .WithMany("Car_ID")
                        .HasForeignKey("RoutesID");
                });

            modelBuilder.Entity("BDTransportCompany.Models.CarsBrands", b =>
                {
                    b.HasOne("BDTransportCompany.Models.Cars", null)
                        .WithMany("CarBrand_ID")
                        .HasForeignKey("CarsID");
                });

            modelBuilder.Entity("BDTransportCompany.Models.Positions", b =>
                {
                    b.HasOne("BDTransportCompany.Models.Staff", null)
                        .WithMany("Position_ID")
                        .HasForeignKey("StaffID");
                });

            modelBuilder.Entity("BDTransportCompany.Models.Staff", b =>
                {
                    b.HasOne("BDTransportCompany.Models.Cars", null)
                        .WithMany("Position_ID1")
                        .HasForeignKey("CarsID");

                    b.HasOne("BDTransportCompany.Models.Cars", null)
                        .WithMany("Position_ID2")
                        .HasForeignKey("CarsID1");

                    b.HasOne("BDTransportCompany.Models.Routes", null)
                        .WithMany("Staff_ID")
                        .HasForeignKey("RoutesID");
                });

            modelBuilder.Entity("BDTransportCompany.Models.TypesOfCargos", b =>
                {
                    b.HasOne("BDTransportCompany.Models.Cargos", null)
                        .WithMany("TypesOfCargos_ID")
                        .HasForeignKey("CargosID");
                });

            modelBuilder.Entity("BDTransportCompany.Models.TypesOfCars", b =>
                {
                    b.HasOne("BDTransportCompany.Models.Cars", null)
                        .WithMany("TypeOfCar_ID")
                        .HasForeignKey("CarsID");

                    b.HasOne("BDTransportCompany.Models.TypesOfCargos", null)
                        .WithMany("TypeOfCar_ID")
                        .HasForeignKey("TypesOfCargosID");
                });
#pragma warning restore 612, 618
        }
    }
}
