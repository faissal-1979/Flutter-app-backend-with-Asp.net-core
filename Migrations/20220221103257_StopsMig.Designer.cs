﻿// <auto-generated />
using System;
using BusAppBackend.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BusAppBackend.Migrations
{
    [DbContext(typeof(BbaContext))]
    [Migration("20220221103257_StopsMig")]
    partial class StopsMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BusAppBackend.Entities.BusEntity", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("marque")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("model")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("nbrSeats")
                        .HasColumnType("int");

                    b.Property<string>("year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("CompanyId");

                    b.ToTable("BusEntity");

                    b.HasData(
                        new
                        {
                            id = 1,
                            CompanyId = 1,
                            marque = "chevy",
                            model = "F32 camaro",
                            nbrSeats = 50,
                            year = "2022"
                        },
                        new
                        {
                            id = 2,
                            CompanyId = 1,
                            marque = "mercedes",
                            model = "benz",
                            nbrSeats = 60,
                            year = "2021"
                        },
                        new
                        {
                            id = 3,
                            CompanyId = 2,
                            marque = "vols",
                            model = "777 vols",
                            nbrSeats = 55,
                            year = "2020"
                        });
                });

            modelBuilder.Entity("BusAppBackend.Entities.BusImgUrlEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BusEntityId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BusEntityId");

                    b.ToTable("BusImgUrlEntity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BusEntityId = 1,
                            Url = "url for chevy 1"
                        },
                        new
                        {
                            Id = 2,
                            BusEntityId = 1,
                            Url = "url for chevy 2"
                        },
                        new
                        {
                            Id = 3,
                            BusEntityId = 2,
                            Url = "url for benz"
                        });
                });

            modelBuilder.Entity("BusAppBackend.Entities.ClientEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.HasKey("Id");

                    b.ToTable("ClientEntity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            age = 21,
                            email = "rnb@gmail.com",
                            gender = "M",
                            name = "rock n roll baby",
                            password = "azerty",
                            phoneNumber = "07586535"
                        },
                        new
                        {
                            Id = 2,
                            age = 29,
                            email = "Steph@gmail.com",
                            gender = "M",
                            name = "CURRY",
                            password = "chefCurry",
                            phoneNumber = "06585535"
                        },
                        new
                        {
                            Id = 3,
                            age = 40,
                            email = "yela@gmail.com",
                            gender = "M",
                            name = "yela",
                            password = "MakeMeBeliver",
                            phoneNumber = "05196732"
                        });
                });

            modelBuilder.Entity("BusAppBackend.Entities.CompanyEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Wilaya")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("CompanyEntity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adress = "adr 1",
                            Name = "bus comp 1",
                            Wilaya = "ghardaia"
                        },
                        new
                        {
                            Id = 2,
                            Adress = "adr 2",
                            Name = "bus comp 2",
                            Wilaya = "alger"
                        });
                });

            modelBuilder.Entity("BusAppBackend.Entities.ReservationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("TripId");

                    b.ToTable("ReservationEntity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientId = 1,
                            Status = "valide",
                            TripId = 1
                        },
                        new
                        {
                            Id = 2,
                            ClientId = 2,
                            Status = "pending",
                            TripId = 2
                        });
                });

            modelBuilder.Entity("BusAppBackend.Entities.StopsEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Stops")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("TripEntityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TripEntityId");

                    b.ToTable("StopsEntity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Stops = "laghwat,djelfa,msilla,bordj"
                        },
                        new
                        {
                            Id = 2,
                            Stops = "laghwat,djelfa,bosaada,media"
                        },
                        new
                        {
                            Id = 3,
                            Stops = "wilaya A,wilaya B,wilaya C "
                        });
                });

            modelBuilder.Entity("BusAppBackend.Entities.TripEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Arrivel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BusId")
                        .HasColumnType("int");

                    b.Property<string>("Commentaire")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateDepart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Depart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NbrPlaces")
                        .HasColumnType("int");

                    b.Property<int>("Note")
                        .HasColumnType("int");

                    b.Property<int>("StopsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BusId");

                    b.ToTable("TripsEntity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Arrivel = "alger",
                            BusId = 1,
                            Commentaire = "its cool bus !",
                            DateDepart = "2022-12-06/6:00 am",
                            Depart = "ghardaia",
                            NbrPlaces = 3,
                            Note = 10,
                            StopsId = 2
                        },
                        new
                        {
                            Id = 2,
                            Arrivel = "ghardaia",
                            BusId = 2,
                            Commentaire = "its not bad trip  !",
                            DateDepart = "2022-12-06/14:00 pm",
                            Depart = "setif",
                            NbrPlaces = 1,
                            Note = 8,
                            StopsId = 1
                        });
                });

            modelBuilder.Entity("BusAppBackend.Entities.BusEntity", b =>
                {
                    b.HasOne("BusAppBackend.Entities.CompanyEntity", "Company")
                        .WithMany("BusEntities")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusAppBackend.Entities.BusImgUrlEntity", b =>
                {
                    b.HasOne("BusAppBackend.Entities.BusEntity", "Bus")
                        .WithMany("BusImgUrlEntity")
                        .HasForeignKey("BusEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusAppBackend.Entities.ReservationEntity", b =>
                {
                    b.HasOne("BusAppBackend.Entities.ClientEntity", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusAppBackend.Entities.TripEntity", "Trip")
                        .WithMany()
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusAppBackend.Entities.StopsEntity", b =>
                {
                    b.HasOne("BusAppBackend.Entities.TripEntity", null)
                        .WithMany("Stops")
                        .HasForeignKey("TripEntityId");
                });

            modelBuilder.Entity("BusAppBackend.Entities.TripEntity", b =>
                {
                    b.HasOne("BusAppBackend.Entities.BusEntity", "Bus")
                        .WithMany()
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
