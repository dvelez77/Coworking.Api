﻿// <auto-generated />
using System;
using Coworking.Api.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Coworking.Api.DataAccess.Migrations
{
    [DbContext(typeof(CoworkingDBContext))]
    partial class CoworkingDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.AdminEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.BookingEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<bool>("RentWorkSpace")
                        .HasColumnType("bit");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.OfficeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasIndividualWorkSpace")
                        .HasColumnType("bit");

                    b.Property<int>("IdAdmin")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberWorkSpaces")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PriceWorkSpaceDaily")
                        .HasColumnType("real");

                    b.Property<float>("PriceWorkSpaceMonthly")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.Offices2RoomsEntity", b =>
                {
                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("OfficeId", "RoomId");

                    b.HasIndex("RoomId");

                    b.ToTable("Office2Room");
                });

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.Room2ServicesEntity", b =>
                {
                    b.Property<int>("IdRoom")
                        .HasColumnType("int");

                    b.Property<int>("IdService")
                        .HasColumnType("int");

                    b.HasKey("IdRoom", "IdService");

                    b.HasIndex("IdService");

                    b.ToTable("Room2Services");
                });

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.RoomEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.ServiceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.BookingEntity", b =>
                {
                    b.HasOne("Coworking.Api.DataAccess.Contracts.Entities.OfficeEntity", "Office")
                        .WithOne("Booking")
                        .HasForeignKey("Coworking.Api.DataAccess.Contracts.Entities.BookingEntity", "OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Coworking.Api.DataAccess.Contracts.Entities.UserEntity", "User")
                        .WithOne("Booking")
                        .HasForeignKey("Coworking.Api.DataAccess.Contracts.Entities.BookingEntity", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.OfficeEntity", b =>
                {
                    b.HasOne("Coworking.Api.DataAccess.Contracts.Entities.AdminEntity", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminId");
                });

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.Offices2RoomsEntity", b =>
                {
                    b.HasOne("Coworking.Api.DataAccess.Contracts.Entities.OfficeEntity", "Office")
                        .WithMany("Office2Room")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Coworking.Api.DataAccess.Contracts.Entities.RoomEntity", "Room")
                        .WithMany("Office2Room")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.Room2ServicesEntity", b =>
                {
                    b.HasOne("Coworking.Api.DataAccess.Contracts.Entities.RoomEntity", "Room")
                        .WithMany("Room2Service")
                        .HasForeignKey("IdRoom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Coworking.Api.DataAccess.Contracts.Entities.ServiceEntity", "Service")
                        .WithMany("Room2Service")
                        .HasForeignKey("IdService")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
