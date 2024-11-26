﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestMatch.API.Infrastructure.Data;

#nullable disable

namespace RestMatch.API.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241126135812_Fixed-Favourites_Relations")]
    partial class FixedFavourites_Relations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RestMatch.API.Domain.Models.CuisineType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cuisines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Italian"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Chinese"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mexican"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Japanese"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Indian"
                        },
                        new
                        {
                            Id = 6,
                            Name = "French"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Mediterranean"
                        },
                        new
                        {
                            Id = 8,
                            Name = "American"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Greek"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Ukrainian"
                        });
                });

            modelBuilder.Entity("RestMatch.API.Domain.Models.Favourite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("UserId");

                    b.ToTable("Favourites");
                });

            modelBuilder.Entity("RestMatch.API.Domain.Models.Recomendations.RestaurantCriteria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("American")
                        .HasColumnType("float");

                    b.Property<double>("Chinese")
                        .HasColumnType("float");

                    b.Property<int>("CountOfRateAmerican")
                        .HasColumnType("int");

                    b.Property<int>("CountOfRateChinese")
                        .HasColumnType("int");

                    b.Property<int>("CountOfRateFrench")
                        .HasColumnType("int");

                    b.Property<int>("CountOfRateGreek")
                        .HasColumnType("int");

                    b.Property<int>("CountOfRateIndian")
                        .HasColumnType("int");

                    b.Property<int>("CountOfRateItalian")
                        .HasColumnType("int");

                    b.Property<int>("CountOfRateJapanese")
                        .HasColumnType("int");

                    b.Property<int>("CountOfRateMediterranean")
                        .HasColumnType("int");

                    b.Property<int>("CountOfRateMexican")
                        .HasColumnType("int");

                    b.Property<int>("CountOfRateUkrainian")
                        .HasColumnType("int");

                    b.Property<double>("French")
                        .HasColumnType("float");

                    b.Property<double>("Greek")
                        .HasColumnType("float");

                    b.Property<double>("Indian")
                        .HasColumnType("float");

                    b.Property<double>("Italian")
                        .HasColumnType("float");

                    b.Property<double>("Japanese")
                        .HasColumnType("float");

                    b.Property<double>("Mediterranean")
                        .HasColumnType("float");

                    b.Property<double>("Mexican")
                        .HasColumnType("float");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<double>("Ukrainian")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("RestaurantCriterias");
                });

            modelBuilder.Entity("RestMatch.API.Domain.Models.Recomendations.UserCriteria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("American")
                        .HasColumnType("float");

                    b.Property<double>("Chinese")
                        .HasColumnType("float");

                    b.Property<int>("CountOfRateAmerican")
                        .HasColumnType("int");

                    b.Property<int>("CountOfRateChinese")
                        .HasColumnType("int");

                    b.Property<int>("CountOfRateFrench")
                        .HasColumnType("int");

                    b.Property<int>("CountOfRateGreek")
                        .HasColumnType("int");

                    b.Property<int>("CountOfRateIndian")
                        .HasColumnType("int");

                    b.Property<int>("CountOfRateItalian")
                        .HasColumnType("int");

                    b.Property<int>("CountOfRateJapanese")
                        .HasColumnType("int");

                    b.Property<int>("CountOfRateMediterranean")
                        .HasColumnType("int");

                    b.Property<int>("CountOfRateMexican")
                        .HasColumnType("int");

                    b.Property<int>("CountOfRateUkrainian")
                        .HasColumnType("int");

                    b.Property<double>("French")
                        .HasColumnType("float");

                    b.Property<double>("Greek")
                        .HasColumnType("float");

                    b.Property<double>("Indian")
                        .HasColumnType("float");

                    b.Property<double>("Italian")
                        .HasColumnType("float");

                    b.Property<double>("Japanese")
                        .HasColumnType("float");

                    b.Property<double>("Mediterranean")
                        .HasColumnType("float");

                    b.Property<double>("Mexican")
                        .HasColumnType("float");

                    b.Property<double>("Ukrainian")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserCriterias");
                });

            modelBuilder.Entity("RestMatch.API.Domain.Models.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AboutText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("ClosingTime")
                        .HasColumnType("time");

                    b.Property<int>("CountOfRate")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("LowerPrice")
                        .HasColumnType("int");

                    b.Property<string>("MenuUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("OpeningTime")
                        .HasColumnType("time");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<int>("UpperPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AboutText = "A cozy restaurant in the heart of the forest, offering seasonal dishes.",
                            Address = "123 Forest Lane, Oakland",
                            City = "Oakland",
                            ClosingTime = new TimeSpan(0, 22, 0, 0, 0),
                            CountOfRate = 0,
                            Country = "Fictivia",
                            CreatedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1274),
                            LowerPrice = 20,
                            MenuUrl = "https://www.goldenoak.com/menu",
                            ModifiedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1277),
                            Name = "The Golden Oak",
                            OpeningTime = new TimeSpan(0, 10, 0, 0, 0),
                            PhoneNumber = "+1 234-567-8901",
                            Rating = 4.2999999999999998,
                            UpperPrice = 50
                        },
                        new
                        {
                            Id = 2,
                            AboutText = "Serving fusion dishes with a magical twist.",
                            Address = "45 Crescent Drive, Moonlight",
                            City = "Moonlight",
                            ClosingTime = new TimeSpan(0, 23, 0, 0, 0),
                            CountOfRate = 0,
                            Country = "Etherea",
                            CreatedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1278),
                            LowerPrice = 30,
                            MenuUrl = "https://www.lunabistro.com/menu",
                            ModifiedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1279),
                            Name = "Luna’s Bistro",
                            OpeningTime = new TimeSpan(0, 11, 0, 0, 0),
                            PhoneNumber = "+2 345-678-9012",
                            Rating = 4.7000000000000002,
                            UpperPrice = 75
                        },
                        new
                        {
                            Id = 3,
                            AboutText = "A steakhouse specializing in rare cuts and wines.",
                            Address = "89 Ironwood Avenue, Redstone",
                            City = "Redstone",
                            ClosingTime = new TimeSpan(0, 23, 30, 0, 0),
                            CountOfRate = 0,
                            Country = "Fictivia",
                            CreatedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1279),
                            LowerPrice = 50,
                            MenuUrl = "https://www.crimsonbarrel.com/menu",
                            ModifiedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1279),
                            Name = "Crimson Barrel",
                            OpeningTime = new TimeSpan(0, 12, 0, 0, 0),
                            PhoneNumber = "+3 567-890-1234",
                            Rating = 4.5,
                            UpperPrice = 150
                        },
                        new
                        {
                            Id = 4,
                            AboutText = "Upscale dining with an elegant atmosphere.",
                            Address = "25 Sparkling Rd, Glimmerstone",
                            City = "Glimmerstone",
                            ClosingTime = new TimeSpan(0, 20, 0, 0, 0),
                            CountOfRate = 0,
                            Country = "Arcadia",
                            CreatedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1280),
                            LowerPrice = 40,
                            MenuUrl = "https://www.velvetspoon.com/menu",
                            ModifiedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1280),
                            Name = "The Velvet Spoon",
                            OpeningTime = new TimeSpan(0, 8, 30, 0, 0),
                            PhoneNumber = "+4 678-901-2345",
                            Rating = 4.2000000000000002,
                            UpperPrice = 80
                        },
                        new
                        {
                            Id = 5,
                            AboutText = "Fresh seafood and grill dishes with an ocean view.",
                            Address = "101 Beachfront Blvd, Oceanview",
                            City = "Oceanview",
                            ClosingTime = new TimeSpan(0, 21, 30, 0, 0),
                            CountOfRate = 0,
                            Country = "Nautica",
                            CreatedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1280),
                            LowerPrice = 25,
                            MenuUrl = "https://www.seasidegrill.com/menu",
                            ModifiedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1281),
                            Name = "Seaside Grill",
                            OpeningTime = new TimeSpan(0, 9, 0, 0, 0),
                            PhoneNumber = "+5 890-123-4567",
                            Rating = 4.5999999999999996,
                            UpperPrice = 60
                        });
                });

            modelBuilder.Entity("RestMatch.API.Domain.Models.RestaurantCuisine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("TypeId");

                    b.ToTable("RestaurantCuisines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1484),
                            ModifiedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1485),
                            RestaurantId = 1,
                            TypeId = 9
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1488),
                            ModifiedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1488),
                            RestaurantId = 1,
                            TypeId = 10
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1537),
                            ModifiedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1537),
                            RestaurantId = 2,
                            TypeId = 3
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1545),
                            ModifiedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1546),
                            RestaurantId = 3,
                            TypeId = 3
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1553),
                            ModifiedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1553),
                            RestaurantId = 4,
                            TypeId = 2
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1555),
                            ModifiedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1556),
                            RestaurantId = 4,
                            TypeId = 10
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1564),
                            ModifiedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1564),
                            RestaurantId = 5,
                            TypeId = 2
                        });
                });

            modelBuilder.Entity("RestMatch.API.Domain.Models.RestaurantImageUrl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("RestaurantImageUrls");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1369),
                            ModifiedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1370),
                            RestaurantId = 1,
                            Url = "http://example.com/the_golden_oak0"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1372),
                            ModifiedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1372),
                            RestaurantId = 1,
                            Url = "http://example.com/the_golden_oak1"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1405),
                            ModifiedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1405),
                            RestaurantId = 2,
                            Url = "http://example.com/luna’s_bistro0"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1407),
                            ModifiedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1408),
                            RestaurantId = 3,
                            Url = "http://example.com/crimson_barrel0"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1410),
                            ModifiedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1410),
                            RestaurantId = 4,
                            Url = "http://example.com/the_velvet_spoon0"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1412),
                            ModifiedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1412),
                            RestaurantId = 4,
                            Url = "http://example.com/the_velvet_spoon1"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1414),
                            ModifiedAt = new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1415),
                            RestaurantId = 5,
                            Url = "http://example.com/seaside_grill0"
                        });
                });

            modelBuilder.Entity("RestMatch.API.Domain.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("RestMatch.API.Domain.Models.UserModel.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("RestMatch.API.Domain.Models.UserModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserRoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RestMatch.API.Domain.Models.UserModels.UserSelectedCriteria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CuisineId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CuisineId");

                    b.HasIndex("UserId");

                    b.ToTable("UserSelectedCriterias");
                });

            modelBuilder.Entity("RestMatch.API.Domain.Models.Favourite", b =>
                {
                    b.HasOne("RestMatch.API.Domain.Models.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestMatch.API.Domain.Models.UserModels.User", "User")
                        .WithMany("Favourites")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RestMatch.API.Domain.Models.Recomendations.RestaurantCriteria", b =>
                {
                    b.HasOne("RestMatch.API.Domain.Models.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RestMatch.API.Domain.Models.Recomendations.UserCriteria", b =>
                {
                    b.HasOne("RestMatch.API.Domain.Models.UserModels.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RestMatch.API.Domain.Models.RestaurantCuisine", b =>
                {
                    b.HasOne("RestMatch.API.Domain.Models.Restaurant", "Restaurant")
                        .WithMany("Cuisines")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestMatch.API.Domain.Models.CuisineType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("RestMatch.API.Domain.Models.RestaurantImageUrl", b =>
                {
                    b.HasOne("RestMatch.API.Domain.Models.Restaurant", "Restaurant")
                        .WithMany("ImageUrls")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RestMatch.API.Domain.Models.Review", b =>
                {
                    b.HasOne("RestMatch.API.Domain.Models.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestMatch.API.Domain.Models.UserModels.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RestMatch.API.Domain.Models.UserModel.Role", b =>
                {
                    b.HasOne("RestMatch.API.Domain.Models.UserModels.User", null)
                        .WithMany("Role")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("RestMatch.API.Domain.Models.UserModels.UserSelectedCriteria", b =>
                {
                    b.HasOne("RestMatch.API.Domain.Models.CuisineType", "Cuisine")
                        .WithMany("SelectedCriterias")
                        .HasForeignKey("CuisineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestMatch.API.Domain.Models.UserModels.User", "User")
                        .WithMany("SelectedCriterias")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cuisine");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RestMatch.API.Domain.Models.CuisineType", b =>
                {
                    b.Navigation("SelectedCriterias");
                });

            modelBuilder.Entity("RestMatch.API.Domain.Models.Restaurant", b =>
                {
                    b.Navigation("Cuisines");

                    b.Navigation("ImageUrls");
                });

            modelBuilder.Entity("RestMatch.API.Domain.Models.UserModels.User", b =>
                {
                    b.Navigation("Favourites");

                    b.Navigation("Role");

                    b.Navigation("SelectedCriterias");
                });
#pragma warning restore 612, 618
        }
    }
}
