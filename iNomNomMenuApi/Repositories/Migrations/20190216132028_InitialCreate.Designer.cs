﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories;

namespace Repositories.Migrations
{
    [DbContext(typeof(MenuContext))]
    [Migration("20190216132028_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Repositories.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2019, 2, 16, 15, 20, 28, 276, DateTimeKind.Local).AddTicks(4912),
                            IsDeleted = false,
                            Name = "Lunch Menu"
                        });
                });

            modelBuilder.Entity("Repositories.Models.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("MenuId");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<int>("TimeToPrep");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "It has everything you ever wanted in a sandwich. enough said",
                            MenuId = 1,
                            Name = "Nom your face off Sandwich",
                            Price = 100.0,
                            TimeToPrep = 20
                        },
                        new
                        {
                            Id = 2,
                            Description = "Disappointed",
                            MenuId = 1,
                            Name = "I'm a vegan",
                            Price = 200.0,
                            TimeToPrep = 60
                        },
                        new
                        {
                            Id = 3,
                            Description = "200g beef patty mixed with 10% sirloin, 10% rump and 80% more beef",
                            MenuId = 1,
                            Name = "Anti vegan burger",
                            Price = 120.0,
                            TimeToPrep = 30
                        },
                        new
                        {
                            Id = 4,
                            Description = "Yes people pineapple on pizza, #dealwithit",
                            MenuId = 1,
                            Name = "Hawaiian pizza",
                            Price = 50.0,
                            TimeToPrep = 25
                        },
                        new
                        {
                            Id = 5,
                            Description = "Good luck finding the feta or olives",
                            MenuId = 1,
                            Name = "Greek salad",
                            Price = 80.0,
                            TimeToPrep = 5
                        },
                        new
                        {
                            Id = 6,
                            Description = "Because you never know what you gonna get",
                            MenuId = 1,
                            Name = "Uber eats special",
                            Price = 100.0,
                            TimeToPrep = 20
                        });
                });

            modelBuilder.Entity("Repositories.Models.MenuItem", b =>
                {
                    b.HasOne("Repositories.Models.Menu")
                        .WithMany("Items")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
