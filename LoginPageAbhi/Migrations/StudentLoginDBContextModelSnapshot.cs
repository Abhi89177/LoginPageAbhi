﻿// <auto-generated />
using LoginPageAbhi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LoginPageAbhi.Migrations
{
    [DbContext(typeof(StudentLoginDBContext))]
    partial class StudentLoginDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LoginPageAbhi.Models.StudentLogin", b =>
                {
                    b.Property<int>("RollNum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RollNum"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Enter_Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Enter_Name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Enter_Password");

                    b.HasKey("RollNum");

                    b.ToTable("studentLogins");
                });
#pragma warning restore 612, 618
        }
    }
}