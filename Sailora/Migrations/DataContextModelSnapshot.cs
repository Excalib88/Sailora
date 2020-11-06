﻿// <auto-generated />
using System;
using BoatService.Web.DataAccess.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BoatService.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("BoatService.Web.DataAccess.Implementations.Entities.Boat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("CabinQty")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("SkipperId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SkipperId");

                    b.ToTable("Boats");
                });

            modelBuilder.Entity("BoatService.Web.DataAccess.Implementations.Entities.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Patronymic")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("BoatService.Web.DataAccess.Implementations.Entities.Route", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("BoatService.Web.DataAccess.Implementations.Entities.RoutePoint", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid?>("RouteId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RouteId");

                    b.ToTable("RoutePoints");
                });

            modelBuilder.Entity("BoatService.Web.DataAccess.Implementations.Entities.Skipper", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("PersonId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Skippers");
                });

            modelBuilder.Entity("BoatService.Web.DataAccess.Implementations.Entities.TripOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("BoatId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FreePlaces")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("OwnerId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<Guid?>("RouteId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("BoatId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("RouteId");

                    b.ToTable("TripOrders");
                });

            modelBuilder.Entity("BoatService.Web.DataAccess.Implementations.Entities.TripOrderRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("PersonId")
                        .HasColumnType("uuid");

                    b.Property<int>("PlacesQty")
                        .HasColumnType("integer");

                    b.Property<Guid?>("TripOrderId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("TripOrderId");

                    b.ToTable("TripOrderRequest");
                });

            modelBuilder.Entity("BoatService.Web.DataAccess.Implementations.Entities.Boat", b =>
                {
                    b.HasOne("BoatService.Web.DataAccess.Implementations.Entities.Skipper", "Skipper")
                        .WithMany()
                        .HasForeignKey("SkipperId");
                });

            modelBuilder.Entity("BoatService.Web.DataAccess.Implementations.Entities.RoutePoint", b =>
                {
                    b.HasOne("BoatService.Web.DataAccess.Implementations.Entities.Route", null)
                        .WithMany("RoutePoints")
                        .HasForeignKey("RouteId");
                });

            modelBuilder.Entity("BoatService.Web.DataAccess.Implementations.Entities.Skipper", b =>
                {
                    b.HasOne("BoatService.Web.DataAccess.Implementations.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("BoatService.Web.DataAccess.Implementations.Entities.TripOrder", b =>
                {
                    b.HasOne("BoatService.Web.DataAccess.Implementations.Entities.Boat", "Boat")
                        .WithMany()
                        .HasForeignKey("BoatId");

                    b.HasOne("BoatService.Web.DataAccess.Implementations.Entities.Person", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");

                    b.HasOne("BoatService.Web.DataAccess.Implementations.Entities.Route", "Route")
                        .WithMany()
                        .HasForeignKey("RouteId");
                });

            modelBuilder.Entity("BoatService.Web.DataAccess.Implementations.Entities.TripOrderRequest", b =>
                {
                    b.HasOne("BoatService.Web.DataAccess.Implementations.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("BoatService.Web.DataAccess.Implementations.Entities.TripOrder", "TripOrder")
                        .WithMany("TripOrderRequests")
                        .HasForeignKey("TripOrderId");
                });
#pragma warning restore 612, 618
        }
    }
}
