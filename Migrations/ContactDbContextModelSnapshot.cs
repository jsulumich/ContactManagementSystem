﻿// <auto-generated />
using System;
using ContactManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContactManagementSystem.Migrations
{
    [DbContext(typeof(ContactDbContext))]
    partial class ContactDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("ContactManagementSystem.Data.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}