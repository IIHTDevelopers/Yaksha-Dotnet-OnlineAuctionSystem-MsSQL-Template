﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Online_Auction.DataLayer;

namespace Online_Auction.DataLayer.Migrations
{
    [DbContext(typeof(OnlineAuctionDbContext))]
    partial class OnlineAuctionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Online_Auction.Entities.Bids", b =>
                {
                    b.Property<long>("BidId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<decimal>("BiddingAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("BidId");

                    b.ToTable("Bids");
                });

            modelBuilder.Entity("Online_Auction.Entities.Customer", b =>
                {
                    b.Property<long>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Online_Auction.Entities.Product", b =>
                {
                    b.Property<long>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTime>("BiddingLastDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<long>("SellerId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("StartBiddingAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Online_Auction.Entities.Seller", b =>
                {
                    b.Property<long>("SellerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SellerId");

                    b.ToTable("Sellers");
                });
#pragma warning restore 612, 618
        }
    }
}