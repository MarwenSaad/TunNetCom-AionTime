﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimeLogService.Infrastructure.AionTimeContext;

#nullable disable

namespace TimeLogService.Infrastructure.Migrations
{
    [DbContext(typeof(TimeLogServiceDataBaseContext))]
    [Migration("20250304221431_TeneantId_v2")]
    partial class TeneantId_v2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TimeLogService.Domain.Models.Dbo.AionTimeSubscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("ExpirationDate")
                        .HasColumnType("datetime");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SubsecriptionDate")
                        .HasColumnType("datetime");

                    b.Property<string>("TenantId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("AionTimeSubscription", (string)null);
                });

            modelBuilder.Entity("TimeLogService.Domain.Models.Dbo.AionTimeSubscriptionHistory", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("SubscriptionDate")
                        .HasColumnType("date");

                    b.Property<int>("SubscriptionId")
                        .HasColumnType("int");

                    b.Property<string>("TenantId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("AionTimeSubscriptionHistory", (string)null);
                });

            modelBuilder.Entity("TimeLogService.Domain.Models.Dbo.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AccountUri")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<bool>("IsAionTimeApproved")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("TenantId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex(new[] { "AccountId" }, "IX_Organization_AccountId")
                        .IsUnique();

                    b.HasIndex(new[] { "Name" }, "IX_Organization_Name_Unique")
                        .IsUnique();

                    b.ToTable("Organization", (string)null);
                });

            modelBuilder.Entity("TimeLogService.Domain.Models.Dbo.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ProjectId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("State")
                        .HasColumnType("int");

                    b.Property<string>("TenantId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Visibility")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex(new[] { "ProjectId" }, "IX_Project_ProjectId")
                        .IsUnique();

                    b.ToTable("Project", (string)null);
                });

            modelBuilder.Entity("TimeLogService.Domain.Models.Dbo.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CoreRevision")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PublicAlias")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Revision")
                        .HasColumnType("int");

                    b.Property<string>("TenantId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "UserId" }, "IX_User_UserId")
                        .IsUnique();

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("TimeLogService.Domain.Models.Dbo.WorkItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discription")
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("TenantId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("WorkItem", (string)null);
                });

            modelBuilder.Entity("TimeLogService.Domain.Models.Dbo.WorkItemHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("History")
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("TenantId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("WorkItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkItemId");

                    b.ToTable("WorkItemHistory", (string)null);
                });

            modelBuilder.Entity("TimeLogService.Domain.Models.Dbo.WorkItemTimeLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("TenantId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("Time")
                        .HasColumnType("datetime");

                    b.Property<int>("WorkItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkItemId");

                    b.ToTable("WorkItemTimeLog", (string)null);
                });

            modelBuilder.Entity("TimeLogService.Domain.Models.Dbo.AionTimeSubscription", b =>
                {
                    b.HasOne("TimeLogService.Domain.Models.Dbo.Organization", "Organization")
                        .WithMany("AionTimeSubscriptions")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FKOrganizationSubscription");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("TimeLogService.Domain.Models.Dbo.AionTimeSubscriptionHistory", b =>
                {
                    b.HasOne("TimeLogService.Domain.Models.Dbo.AionTimeSubscription", "Subscription")
                        .WithMany("AionTimeSubscriptionHistories")
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FKSubscriptionSubscriptionHistory");

                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("TimeLogService.Domain.Models.Dbo.Organization", b =>
                {
                    b.HasOne("TimeLogService.Domain.Models.Dbo.User", "User")
                        .WithMany("Organizations")
                        .HasForeignKey("UserId")
                        .HasPrincipalKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FKUserOrganization");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TimeLogService.Domain.Models.Dbo.Project", b =>
                {
                    b.HasOne("TimeLogService.Domain.Models.Dbo.Organization", "Organization")
                        .WithMany("Projects")
                        .HasForeignKey("AccountId")
                        .HasPrincipalKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FKOrganisationProject");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("TimeLogService.Domain.Models.Dbo.WorkItem", b =>
                {
                    b.HasOne("TimeLogService.Domain.Models.Dbo.Project", "Project")
                        .WithMany("WorkItems")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FKProjectTicket");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("TimeLogService.Domain.Models.Dbo.WorkItemHistory", b =>
                {
                    b.HasOne("TimeLogService.Domain.Models.Dbo.WorkItem", "WorkItem")
                        .WithMany("WorkItemHistories")
                        .HasForeignKey("WorkItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FKTicketHistory");

                    b.Navigation("WorkItem");
                });

            modelBuilder.Entity("TimeLogService.Domain.Models.Dbo.WorkItemTimeLog", b =>
                {
                    b.HasOne("TimeLogService.Domain.Models.Dbo.WorkItem", "WorkItem")
                        .WithMany("WorkItemTimeLogs")
                        .HasForeignKey("WorkItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FKProjectTicketLog");

                    b.Navigation("WorkItem");
                });

            modelBuilder.Entity("TimeLogService.Domain.Models.Dbo.AionTimeSubscription", b =>
                {
                    b.Navigation("AionTimeSubscriptionHistories");
                });

            modelBuilder.Entity("TimeLogService.Domain.Models.Dbo.Organization", b =>
                {
                    b.Navigation("AionTimeSubscriptions");

                    b.Navigation("Projects");
                });

            modelBuilder.Entity("TimeLogService.Domain.Models.Dbo.Project", b =>
                {
                    b.Navigation("WorkItems");
                });

            modelBuilder.Entity("TimeLogService.Domain.Models.Dbo.User", b =>
                {
                    b.Navigation("Organizations");
                });

            modelBuilder.Entity("TimeLogService.Domain.Models.Dbo.WorkItem", b =>
                {
                    b.Navigation("WorkItemHistories");

                    b.Navigation("WorkItemTimeLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
