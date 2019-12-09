﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YappiesTesting.Data;

namespace YappiesTesting.Data.Migrations
{
    [DbContext(typeof(yappiesTestingContext))]
    [Migration("20190401030738_AddedSettings")]
    partial class AddedSettings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("YT")
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YappiesTesting.Models.Activity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("ProgramID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("ID");

                    b.HasIndex("ProgramID");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("YappiesTesting.Models.Announcement", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<int?>("ProgramID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("ID");

                    b.HasIndex("ProgramID");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("YappiesTesting.Models.Child", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("ParentID");

                    b.HasKey("ID");

                    b.HasIndex("ParentID");

                    b.ToTable("Children");
                });

            modelBuilder.Entity("YappiesTesting.Models.Conversation", b =>
                {
                    b.Property<int>("ParentID");

                    b.Property<int>("ProgramSupervisorID");

                    b.HasKey("ParentID", "ProgramSupervisorID");

                    b.HasIndex("ProgramSupervisorID");

                    b.ToTable("Conversations");
                });

            modelBuilder.Entity("YappiesTesting.Models.Message", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("MessageText")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<int>("ParentID");

                    b.Property<int>("ProgramSupervisorID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<bool>("SentByParent");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("ID");

                    b.HasIndex("ParentID", "ProgramSupervisorID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("YappiesTesting.Models.Parent", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<bool>("DirectMessageOptIn");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<bool>("NotificationOptIn");

                    b.Property<long>("Phone");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<bool>("SignOutOptIn");

                    b.Property<bool>("TwoFactorOptIn");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("ID");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("YappiesTesting.Models.Program", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("ProgramDescription")
                        .IsRequired()
                        .HasMaxLength(1000000);

                    b.Property<string>("ProgramJoinCode")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("ProgramName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<int>("ProgramSupervisorID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("ID");

                    b.HasIndex("ProgramSupervisorID");

                    b.ToTable("Programs");
                });

            modelBuilder.Entity("YappiesTesting.Models.Program_Child", b =>
                {
                    b.Property<int>("ProgramID");

                    b.Property<int>("ChildID");

                    b.HasKey("ProgramID", "ChildID");

                    b.HasIndex("ChildID");

                    b.ToTable("Programs_Children");
                });

            modelBuilder.Entity("YappiesTesting.Models.Program_Parent", b =>
                {
                    b.Property<int>("ProgramID");

                    b.Property<int>("ParentID");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("ProgramID", "ParentID");

                    b.HasIndex("ParentID");

                    b.ToTable("Programs_Parents");
                });

            modelBuilder.Entity("YappiesTesting.Models.ProgramSupervisor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<long>("Phone");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("ID");

                    b.ToTable("ProgramSupervisors");
                });

            modelBuilder.Entity("YappiesTesting.Models.Activity", b =>
                {
                    b.HasOne("YappiesTesting.Models.Program", "Program")
                        .WithMany("Activities")
                        .HasForeignKey("ProgramID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("YappiesTesting.Models.Announcement", b =>
                {
                    b.HasOne("YappiesTesting.Models.Program", "Program")
                        .WithMany("Announcements")
                        .HasForeignKey("ProgramID");
                });

            modelBuilder.Entity("YappiesTesting.Models.Child", b =>
                {
                    b.HasOne("YappiesTesting.Models.Parent", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("YappiesTesting.Models.Conversation", b =>
                {
                    b.HasOne("YappiesTesting.Models.Parent", "Parent")
                        .WithMany("Conversations")
                        .HasForeignKey("ParentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("YappiesTesting.Models.ProgramSupervisor", "ProgramSupervisor")
                        .WithMany("Conversations")
                        .HasForeignKey("ProgramSupervisorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("YappiesTesting.Models.Message", b =>
                {
                    b.HasOne("YappiesTesting.Models.Conversation")
                        .WithMany("Messages")
                        .HasForeignKey("ParentID", "ProgramSupervisorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("YappiesTesting.Models.Program", b =>
                {
                    b.HasOne("YappiesTesting.Models.ProgramSupervisor", "ProgramSupervisor")
                        .WithMany("Programs")
                        .HasForeignKey("ProgramSupervisorID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("YappiesTesting.Models.Program_Child", b =>
                {
                    b.HasOne("YappiesTesting.Models.Child", "Child")
                        .WithMany("Programs")
                        .HasForeignKey("ChildID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("YappiesTesting.Models.Program", "Program")
                        .WithMany()
                        .HasForeignKey("ProgramID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("YappiesTesting.Models.Program_Parent", b =>
                {
                    b.HasOne("YappiesTesting.Models.Parent", "Parent")
                        .WithMany("Programs")
                        .HasForeignKey("ParentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("YappiesTesting.Models.Program", "Program")
                        .WithMany("Parents")
                        .HasForeignKey("ProgramID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
