﻿// <auto-generated />
using System;
using Appli_EcoPartage.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Appli_EcoPartage.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241217171648_testTitle")]
    partial class testTitle
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Appli_EcoPartage.Data.Annonces", b =>
                {
                    b.Property<int>("IdAnnonce")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAnnonce"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAnnonce");

                    b.HasIndex("IdUser");

                    b.ToTable("Annonces");
                });

            modelBuilder.Entity("Appli_EcoPartage.Data.AnnoncesGeoSector", b =>
                {
                    b.Property<int>("IdAnnonce")
                        .HasColumnType("int");

                    b.Property<int>("IdGeographicalSector")
                        .HasColumnType("int");

                    b.Property<int>("IdAnnoncesGeoSector")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAnnoncesGeoSector"));

                    b.HasKey("IdAnnonce", "IdGeographicalSector", "IdAnnoncesGeoSector");

                    b.HasIndex("IdGeographicalSector");

                    b.ToTable("AnnoncesGeoSectors");
                });

            modelBuilder.Entity("Appli_EcoPartage.Data.AnnoncesTags", b =>
                {
                    b.Property<int>("IdAnnonce")
                        .HasColumnType("int");

                    b.Property<int>("IdTag")
                        .HasColumnType("int");

                    b.Property<int>("IdAnnonceTag")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAnnonceTag"));

                    b.HasKey("IdAnnonce", "IdTag", "IdAnnonceTag");

                    b.HasIndex("IdTag");

                    b.ToTable("AnnoncesTags");
                });

            modelBuilder.Entity("Appli_EcoPartage.Data.Comments", b =>
                {
                    b.Property<int>("IdComment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdComment"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdUserGiven")
                        .HasColumnType("int");

                    b.Property<int>("IdUserRecipient")
                        .HasColumnType("int");

                    b.Property<string>("Notice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdComment");

                    b.HasIndex("IdUserGiven");

                    b.HasIndex("IdUserRecipient");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Appli_EcoPartage.Data.ContactMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateSent")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ContactMessages");
                });

            modelBuilder.Entity("Appli_EcoPartage.Data.GeographicalSector", b =>
                {
                    b.Property<int>("IdGeographicalSector")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdGeographicalSector"));

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdGeographicalSector");

                    b.ToTable("GeographicalSectors");
                });

            modelBuilder.Entity("Appli_EcoPartage.Data.Tags", b =>
                {
                    b.Property<int>("IdTag")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTag"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTag");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Appli_EcoPartage.Data.Transactions", b =>
                {
                    b.Property<int>("IdTransaction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTransaction"));

                    b.Property<DateTime>("DateTransaction")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdAnnonce")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserIdBuyer")
                        .HasColumnType("int");

                    b.Property<int>("UserIdSeller")
                        .HasColumnType("int");

                    b.HasKey("IdTransaction");

                    b.HasIndex("IdAnnonce");

                    b.HasIndex("UserIdBuyer");

                    b.HasIndex("UserIdSeller");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Appli_EcoPartage.Data.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsValidated")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Appli_EcoPartage.Data.Annonces", b =>
                {
                    b.HasOne("Appli_EcoPartage.Data.Users", "User")
                        .WithMany("MyAnnonces")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Appli_EcoPartage.Data.AnnoncesGeoSector", b =>
                {
                    b.HasOne("Appli_EcoPartage.Data.Annonces", "Annonce")
                        .WithMany("AnnoncesGeoSectors")
                        .HasForeignKey("IdAnnonce")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Appli_EcoPartage.Data.GeographicalSector", "GeographicalSector")
                        .WithMany()
                        .HasForeignKey("IdGeographicalSector")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Annonce");

                    b.Navigation("GeographicalSector");
                });

            modelBuilder.Entity("Appli_EcoPartage.Data.AnnoncesTags", b =>
                {
                    b.HasOne("Appli_EcoPartage.Data.Annonces", "Annonce")
                        .WithMany("AnnoncesTags")
                        .HasForeignKey("IdAnnonce")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Appli_EcoPartage.Data.Tags", "Tag")
                        .WithMany()
                        .HasForeignKey("IdTag")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Annonce");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Appli_EcoPartage.Data.Comments", b =>
                {
                    b.HasOne("Appli_EcoPartage.Data.Users", "Giver")
                        .WithMany("CommentsGiven")
                        .HasForeignKey("IdUserGiven")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Appli_EcoPartage.Data.Users", "Recipient")
                        .WithMany("CommentsRecived")
                        .HasForeignKey("IdUserRecipient")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Giver");

                    b.Navigation("Recipient");
                });

            modelBuilder.Entity("Appli_EcoPartage.Data.ContactMessage", b =>
                {
                    b.HasOne("Appli_EcoPartage.Data.Users", "User")
                        .WithMany("ContactMessages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Appli_EcoPartage.Data.Transactions", b =>
                {
                    b.HasOne("Appli_EcoPartage.Data.Annonces", "Annonce")
                        .WithMany()
                        .HasForeignKey("IdAnnonce")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Appli_EcoPartage.Data.Users", "UserBuyer")
                        .WithMany("TransactionsBuyer")
                        .HasForeignKey("UserIdBuyer")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Appli_EcoPartage.Data.Users", "UserSeller")
                        .WithMany("TransactionsSeller")
                        .HasForeignKey("UserIdSeller")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Annonce");

                    b.Navigation("UserBuyer");

                    b.Navigation("UserSeller");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Appli_EcoPartage.Data.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Appli_EcoPartage.Data.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Appli_EcoPartage.Data.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Appli_EcoPartage.Data.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Appli_EcoPartage.Data.Annonces", b =>
                {
                    b.Navigation("AnnoncesGeoSectors");

                    b.Navigation("AnnoncesTags");
                });

            modelBuilder.Entity("Appli_EcoPartage.Data.Users", b =>
                {
                    b.Navigation("CommentsGiven");

                    b.Navigation("CommentsRecived");

                    b.Navigation("ContactMessages");

                    b.Navigation("MyAnnonces");

                    b.Navigation("TransactionsBuyer");

                    b.Navigation("TransactionsSeller");
                });
#pragma warning restore 612, 618
        }
    }
}