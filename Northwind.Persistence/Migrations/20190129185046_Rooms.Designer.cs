﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Northwind.Persistence;

namespace Northwind.Persistence.Migrations
{
    [DbContext(typeof(NorthwindDbContext))]
    [Migration("20190129185046_Rooms")]
    partial class Rooms
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Northwind.Domain.Entities.Date", b =>
                {
                    b.Property<int>("DateId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ReservationDate");

                    b.Property<int>("RoomId");

                    b.HasKey("DateId");

                    b.HasIndex("RoomId");

                    b.ToTable("Dates");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RoomId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Notes");

                    b.Property<int>("RoomCapacity");

                    b.Property<int>("RoomNumber");

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Date", b =>
                {
                    b.HasOne("Northwind.Domain.Entities.Room")
                        .WithMany("ReservationDates")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
