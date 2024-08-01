﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RNRITS.EMPLOYEECRUDAPP.Models;

#nullable disable

namespace RNRITS.EMPLOYEECRUDAPP.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RNRITS.EMPLOYEECRUDAPP.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2")
                        .HasColumnName("DOB");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FirstName");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Gender");

                    b.Property<DateTime>("HigherDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("HIgherDate");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LastName");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Mobile");

                    b.Property<int>("PID")
                        .HasColumnType("int")
                        .HasColumnName("PID");

                    b.Property<double>("salary")
                        .HasColumnType("float")
                        .HasColumnName("Salary");

                    b.HasKey("ID");

                    b.HasIndex("PID");

                    b.ToTable("EMPLOYEE");
                });

            modelBuilder.Entity("RNRITS.EMPLOYEECRUDAPP.Models.Positions", b =>
                {
                    b.Property<int>("PID")
                        .HasColumnType("int");

                    b.Property<string>("PNAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PNAME");

                    b.HasKey("PID");

                    b.ToTable("POSITION");
                });

            modelBuilder.Entity("RNRITS.EMPLOYEECRUDAPP.Models.Employee", b =>
                {
                    b.HasOne("RNRITS.EMPLOYEECRUDAPP.Models.Positions", "Position")
                        .WithMany("Employees")
                        .HasForeignKey("PID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");
                });

            modelBuilder.Entity("RNRITS.EMPLOYEECRUDAPP.Models.Positions", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
