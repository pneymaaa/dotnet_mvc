﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet_mvc.Data;

#nullable disable

namespace dotnet_mvc.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231118084554_modifiedTable")]
    partial class modifiedTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("dotnet_mvc.Models.tblM_Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    //SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.ToTable("tblM_Genders");
                });

            modelBuilder.Entity("dotnet_mvc.Models.tblM_Hobby", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(1)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("tblM_Hobbies");
                });

            modelBuilder.Entity("dotnet_mvc.Models.tblT_Age", b =>
                {
                    b.Property<int>("Age")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    //SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Age"));

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("Age");

                    b.ToTable("tblT_Ages");
                });

            modelBuilder.Entity("dotnet_mvc.Models.tblT_Personal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("IdGender")
                        .HasColumnType("int");

                    b.Property<string>("IdHobby")
                        .IsRequired()
                        .HasColumnType("CHAR(1)");

                    b.Property<string>("Name")
                        .HasColumnType("VARCHAR(25)");

                    b.HasKey("Id");

                    b.HasIndex("Age");

                    b.HasIndex("IdGender");

                    b.HasIndex("IdHobby");

                    b.ToTable("tblT_Personals");
                });

            modelBuilder.Entity("dotnet_mvc.Models.udt_Personal", b =>
                {
                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("GenderName")
                        .HasColumnType("varchar(10)");

                    b.Property<int>("IdGender")
                        .HasColumnType("int");

                    b.Property<string>("IdHobby")
                        .IsRequired()
                        .HasColumnType("char(1)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(25)");

                    b.Property<string>("NameHobby")
                        .HasColumnType("varchar(50)");

                    b.ToTable("udt_Personal");
                });

            modelBuilder.Entity("dotnet_mvc.Models.tblT_Personal", b =>
                {
                    b.HasOne("dotnet_mvc.Models.tblT_Age", "tblT_Age")
                        .WithMany("tblT_Personals")
                        .HasForeignKey("Age")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dotnet_mvc.Models.tblM_Gender", "tblM_Gender")
                        .WithMany("tblT_Personals")
                        .HasForeignKey("IdGender")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dotnet_mvc.Models.tblM_Hobby", "tblM_Hobby")
                        .WithMany("tblT_Personals")
                        .HasForeignKey("IdHobby")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tblM_Gender");

                    b.Navigation("tblM_Hobby");

                    b.Navigation("tblT_Age");
                });

            modelBuilder.Entity("dotnet_mvc.Models.tblM_Gender", b =>
                {
                    b.Navigation("tblT_Personals");
                });

            modelBuilder.Entity("dotnet_mvc.Models.tblM_Hobby", b =>
                {
                    b.Navigation("tblT_Personals");
                });

            modelBuilder.Entity("dotnet_mvc.Models.tblT_Age", b =>
                {
                    b.Navigation("tblT_Personals");
                });
#pragma warning restore 612, 618
        }
    }
}
