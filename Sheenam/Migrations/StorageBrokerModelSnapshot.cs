﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sheenam.Brokers.Storages;

#nullable disable

namespace Sheenam.Migrations
{
    [DbContext(typeof(StorageBroker))]
    partial class StorageBrokerModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true);

            modelBuilder.Entity("Sheenam.Models.Foundations.Homes.Home", b =>
                {
                    b.Property<Guid>("HomeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("HomeType")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("HomeId");

                    b.HasIndex("UserId");

                    b.ToTable("Homes");
                });

            modelBuilder.Entity("Sheenam.Models.Foundations.ImageMetadatas.ImageMetadata", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Format")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("HomeId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsUserAvatar")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<float>("Size")
                        .HasColumnType("REAL");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("HomeId");

                    b.HasIndex("UserId");

                    b.ToTable("ImageMetadatas");
                });

            modelBuilder.Entity("Sheenam.Models.Foundations.Users.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Sheenam.Models.Foundations.Homes.Home", b =>
                {
                    b.HasOne("Sheenam.Models.Foundations.Users.User", "User")
                        .WithMany("UserHomes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Sheenam.Models.Foundations.ImageMetadatas.ImageMetadata", b =>
                {
                    b.HasOne("Sheenam.Models.Foundations.Homes.Home", "Home")
                        .WithMany("ImageMetadata")
                        .HasForeignKey("HomeId");

                    b.HasOne("Sheenam.Models.Foundations.Users.User", "User")
                        .WithMany("ImageMetadata")
                        .HasForeignKey("UserId");

                    b.Navigation("Home");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Sheenam.Models.Foundations.Homes.Home", b =>
                {
                    b.Navigation("ImageMetadata");
                });

            modelBuilder.Entity("Sheenam.Models.Foundations.Users.User", b =>
                {
                    b.Navigation("ImageMetadata");

                    b.Navigation("UserHomes");
                });
#pragma warning restore 612, 618
        }
    }
}
