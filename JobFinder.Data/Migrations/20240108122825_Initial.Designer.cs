﻿// <auto-generated />
using System;
using JobFinder.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobFinder.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240108122825_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JobFinder.Entities.Entities.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CoverLetter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<int>("JobSeekerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifiedById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.HasIndex("JobSeekerId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("JobFinder.Entities.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanyProfilePictureId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyProfilePictureId")
                        .IsUnique()
                        .HasFilter("[CompanyProfilePictureId] IS NOT NULL");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("JobFinder.Entities.Entities.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ContentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FileId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("JobFinder.Entities.Entities.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("JobFinder.Entities.Entities.JobSeeker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsFresh")
                        .HasColumnType("bit");

                    b.Property<int?>("JobSeekerCvId")
                        .HasColumnType("int");

                    b.Property<int?>("JobSeekerProfilePictureId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("YearsOfExperience")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JobSeekerCvId")
                        .IsUnique()
                        .HasFilter("[JobSeekerCvId] IS NOT NULL");

                    b.HasIndex("JobSeekerProfilePictureId")
                        .IsUnique()
                        .HasFilter("[JobSeekerProfilePictureId] IS NOT NULL");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("JobSeekers");
                });

            modelBuilder.Entity("JobFinder.Entities.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedById = 0,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModificationDate = new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Local),
                            ModifiedById = 0,
                            Name = "JobSeeker"
                        },
                        new
                        {
                            Id = 2,
                            CreatedById = 0,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModificationDate = new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Local),
                            ModifiedById = 0,
                            Name = "Employer"
                        });
                });

            modelBuilder.Entity("JobFinder.Entities.Entities.UserManagement.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsCompany")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("JobFinder.Entities.Entities.UserManagement.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("JobFinder.Entities.Entities.Application", b =>
                {
                    b.HasOne("JobFinder.Entities.Entities.Job", "Job")
                        .WithMany("Applications")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("JobFinder.Entities.Entities.JobSeeker", "JobSeeker")
                        .WithMany("Applications")
                        .HasForeignKey("JobSeekerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Job");

                    b.Navigation("JobSeeker");
                });

            modelBuilder.Entity("JobFinder.Entities.Entities.Company", b =>
                {
                    b.HasOne("JobFinder.Entities.Entities.File", "CompanyProfilePicture")
                        .WithOne()
                        .HasForeignKey("JobFinder.Entities.Entities.Company", "CompanyProfilePictureId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("JobFinder.Entities.Entities.UserManagement.User", "User")
                        .WithOne("Company")
                        .HasForeignKey("JobFinder.Entities.Entities.Company", "UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CompanyProfilePicture");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JobFinder.Entities.Entities.Job", b =>
                {
                    b.HasOne("JobFinder.Entities.Entities.Company", "Company")
                        .WithMany("Jobs")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("JobFinder.Entities.Entities.JobSeeker", b =>
                {
                    b.HasOne("JobFinder.Entities.Entities.File", "JobSeekerCv")
                        .WithOne()
                        .HasForeignKey("JobFinder.Entities.Entities.JobSeeker", "JobSeekerCvId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("JobFinder.Entities.Entities.File", "JobSeekerProfilePicture")
                        .WithOne()
                        .HasForeignKey("JobFinder.Entities.Entities.JobSeeker", "JobSeekerProfilePictureId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("JobFinder.Entities.Entities.UserManagement.User", "User")
                        .WithOne("JobSeeker")
                        .HasForeignKey("JobFinder.Entities.Entities.JobSeeker", "UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("JobSeekerCv");

                    b.Navigation("JobSeekerProfilePicture");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JobFinder.Entities.Entities.UserManagement.UserRole", b =>
                {
                    b.HasOne("JobFinder.Entities.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("JobFinder.Entities.Entities.UserManagement.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JobFinder.Entities.Entities.Company", b =>
                {
                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("JobFinder.Entities.Entities.Job", b =>
                {
                    b.Navigation("Applications");
                });

            modelBuilder.Entity("JobFinder.Entities.Entities.JobSeeker", b =>
                {
                    b.Navigation("Applications");
                });

            modelBuilder.Entity("JobFinder.Entities.Entities.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("JobFinder.Entities.Entities.UserManagement.User", b =>
                {
                    b.Navigation("Company");

                    b.Navigation("JobSeeker");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
