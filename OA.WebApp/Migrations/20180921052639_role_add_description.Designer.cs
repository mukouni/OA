﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OA.WebApp.Data;

namespace OA.WebApp.Migrations
{
    [DbContext(typeof(OAContext))]
    [Migration("20180921052639_role_add_description")]
    partial class role_add_description
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OA.WebApp.Models.Company", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Deleted");

                    b.Property<DateTime?>("ModifiedAt");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Name");

                    b.Property<int>("ParentCompanyID");

                    b.HasKey("ID");

                    b.ToTable("st_company");
                });

            modelBuilder.Entity("OA.WebApp.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Deleted");

                    b.Property<DateTime?>("ModifiedAt");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Name");

                    b.Property<int>("ParentDepartmentID");

                    b.HasKey("ID");

                    b.ToTable("st_department");
                });

            modelBuilder.Entity("OA.WebApp.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Sex");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("st_employee");
                });

            modelBuilder.Entity("OA.WebApp.Models.Privilege", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActionName");

                    b.Property<string>("ControllerName");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Deleted");

                    b.Property<string>("Description");

                    b.Property<bool>("IsUsed");

                    b.Property<DateTime?>("ModifiedAt");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Module");

                    b.Property<string>("Name");

                    b.Property<bool>("ScopeEnable");

                    b.HasKey("ID");

                    b.ToTable("st_privilege");
                });

            modelBuilder.Entity("OA.WebApp.Models.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Deleted");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("ModifiedAt");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("st_role");
                });

            modelBuilder.Entity("OA.WebApp.Models.RolePrivilege", b =>
                {
                    b.Property<int>("RoleID");

                    b.Property<int>("PrivilegeID");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Deleted");

                    b.Property<int>("ID");

                    b.Property<DateTime?>("ModifiedAt");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Scope");

                    b.Property<string>("UniquePriv");

                    b.HasKey("RoleID", "PrivilegeID");

                    b.HasAlternateKey("ID");

                    b.HasIndex("PrivilegeID");

                    b.ToTable("st_role_privilege");
                });

            modelBuilder.Entity("OA.WebApp.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Deleted");

                    b.Property<DateTime?>("ModifiedAt");

                    b.Property<string>("ModifiedBy");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("st_user");
                });

            modelBuilder.Entity("OA.WebApp.Models.UserCompany", b =>
                {
                    b.Property<int>("UserID");

                    b.Property<int>("CompanyID");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Deleted");

                    b.Property<DateTime?>("ModifiedAt");

                    b.Property<string>("ModifiedBy");

                    b.HasKey("UserID", "CompanyID");

                    b.HasAlternateKey("CompanyID", "UserID");

                    b.ToTable("st_user_company");
                });

            modelBuilder.Entity("OA.WebApp.Models.UserDepartment", b =>
                {
                    b.Property<int>("UserID");

                    b.Property<int>("DepartmentID");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Deleted");

                    b.Property<DateTime?>("ModifiedAt");

                    b.Property<string>("ModifiedBy");

                    b.HasKey("UserID", "DepartmentID");

                    b.HasAlternateKey("DepartmentID", "UserID");

                    b.ToTable("st_user_department");
                });

            modelBuilder.Entity("OA.WebApp.Models.UserPrivilege", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActionName");

                    b.Property<string>("ControllerName");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Deleted");

                    b.Property<DateTime?>("ModifiedAt");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Scope");

                    b.Property<string>("UniquePriv");

                    b.Property<int?>("UserID1");

                    b.HasKey("UserID");

                    b.HasIndex("UserID1");

                    b.ToTable("st_user_privilege");
                });

            modelBuilder.Entity("OA.WebApp.Models.UserRole", b =>
                {
                    b.Property<int>("UserID");

                    b.Property<int>("RoleID");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Deleted");

                    b.Property<DateTime?>("ModifiedAt");

                    b.Property<string>("ModifiedBy");

                    b.HasKey("UserID", "RoleID");

                    b.HasAlternateKey("RoleID", "UserID");

                    b.ToTable("st_user_role");
                });

            modelBuilder.Entity("OA.WebApp.Models.Vessel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CloseDate");

                    b.Property<DateTime?>("ETD");

                    b.Property<string>("LocalName");

                    b.Property<string>("Name");

                    b.Property<DateTime>("OpDate");

                    b.Property<string>("Port");

                    b.Property<bool>("Trade");

                    b.Property<string>("Voy");

                    b.HasKey("ID");

                    b.ToTable("Vessels");
                });

            modelBuilder.Entity("OA.WebApp.Models.Employee", b =>
                {
                    b.HasOne("OA.WebApp.Models.User", "User")
                        .WithOne("Employee")
                        .HasForeignKey("OA.WebApp.Models.Employee", "UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OA.WebApp.Models.RolePrivilege", b =>
                {
                    b.HasOne("OA.WebApp.Models.Privilege", "Privilege")
                        .WithMany("RolePrivileges")
                        .HasForeignKey("PrivilegeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OA.WebApp.Models.Role", "Role")
                        .WithMany("RolePrivileges")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OA.WebApp.Models.UserCompany", b =>
                {
                    b.HasOne("OA.WebApp.Models.Company", "Company")
                        .WithMany("UserCompanies")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OA.WebApp.Models.User", "User")
                        .WithMany("UserCompanies")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OA.WebApp.Models.UserDepartment", b =>
                {
                    b.HasOne("OA.WebApp.Models.Department", "Department")
                        .WithMany("UserDepartments")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OA.WebApp.Models.User", "User")
                        .WithMany("UserDepartments")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OA.WebApp.Models.UserPrivilege", b =>
                {
                    b.HasOne("OA.WebApp.Models.User", "User")
                        .WithMany("UserPrivileges")
                        .HasForeignKey("UserID1");
                });

            modelBuilder.Entity("OA.WebApp.Models.UserRole", b =>
                {
                    b.HasOne("OA.WebApp.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OA.WebApp.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
