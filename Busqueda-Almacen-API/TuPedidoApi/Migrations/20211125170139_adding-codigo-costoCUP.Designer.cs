﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sistia.Models;

namespace Sistia.Migrations
{
    [DbContext(typeof(SistiaDB))]
    [Migration("20211125170139_adding-codigo-costoCUP")]
    partial class addingcodigocostoCUP
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Sistia.Models.Articulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad");

                    b.Property<string>("Codigo");

                    b.Property<int?>("Existencia");

                    b.Property<int>("IntervaloId");

                    b.Property<string>("Nombre");

                    b.Property<double>("PrecioCUP");

                    b.Property<string>("UM");

                    b.Property<string>("Utm_mov");

                    b.HasKey("Id");

                    b.HasIndex("IntervaloId");

                    b.ToTable("Articulos");
                });

            modelBuilder.Entity("Sistia.Models.Necesidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad");

                    b.Property<string>("Codigo");

                    b.Property<string>("Estado");

                    b.Property<int?>("Existencia");

                    b.Property<int>("IntervaloId");

                    b.Property<string>("Nombre");

                    b.Property<string>("NombrePozo");

                    b.Property<int>("PozoId");

                    b.Property<double>("PrecioCUP");

                    b.Property<string>("UM");

                    b.Property<string>("Utm_mov");

                    b.HasKey("Id");

                    b.ToTable("Necesidades");
                });

            modelBuilder.Entity("TuPedidoApi.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<long?>("FacebookId");

                    b.Property<string>("FamilyName");

                    b.Property<long?>("GoogleId");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name");

                    b.Property<string>("NickName");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("PictureUrl");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("TuPedidoApi.Models.Construccion", b =>
                {
                    b.Property<int>("ConstruccionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PozoId");

                    b.HasKey("ConstruccionId");

                    b.HasIndex("PozoId")
                        .IsUnique();

                    b.ToTable("Construcciones");
                });

            modelBuilder.Entity("TuPedidoApi.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Gender");

                    b.Property<string>("IdentityId");

                    b.Property<string>("Locale");

                    b.Property<string>("Location");

                    b.HasKey("Id");

                    b.HasIndex("IdentityId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("TuPedidoApi.Models.Intervalo", b =>
                {
                    b.Property<int>("IntervaloId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Barrena");

                    b.Property<string>("Camisa");

                    b.Property<int>("ConstruccionId");

                    b.Property<string>("Longitud");

                    b.Property<double>("PrecioB");

                    b.Property<double>("PrecioC");

                    b.HasKey("IntervaloId");

                    b.HasIndex("ConstruccionId");

                    b.ToTable("Intervalos");
                });

            modelBuilder.Entity("TuPedidoApi.Models.Partner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName");

                    b.Property<string>("IdentityId");

                    b.Property<string>("Locale");

                    b.Property<string>("OwnerIdentityId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerIdentityId");

                    b.ToTable("Partners");
                });

            modelBuilder.Entity("TuPedidoApi.Models.Pozo", b =>
                {
                    b.Property<int>("PozoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Campana");

                    b.Property<DateTime?>("FechaFin");

                    b.Property<DateTime?>("FechaInicio");

                    b.Property<string>("NombrePozo")
                        .IsRequired();

                    b.Property<string>("Ubicacion")
                        .IsRequired();

                    b.HasKey("PozoId");

                    b.ToTable("Pozos");
                });

            modelBuilder.Entity("TuPedidoApi.Models.Servicio", b =>
                {
                    b.Property<int>("ServicioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo");

                    b.Property<double>("CostoCUP");

                    b.Property<string>("Descripcion");

                    b.Property<string>("Empresa");

                    b.Property<DateTime?>("FechaFin");

                    b.Property<DateTime?>("FechaInicio");

                    b.Property<int?>("IntervaloId");

                    b.Property<int>("PozoId");

                    b.Property<string>("TipoServicio");

                    b.HasKey("ServicioId");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TuPedidoApi.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TuPedidoApi.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TuPedidoApi.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TuPedidoApi.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sistia.Models.Articulo", b =>
                {
                    b.HasOne("TuPedidoApi.Models.Intervalo")
                        .WithMany("Recursos")
                        .HasForeignKey("IntervaloId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TuPedidoApi.Models.Construccion", b =>
                {
                    b.HasOne("TuPedidoApi.Models.Pozo")
                        .WithOne("Construccion")
                        .HasForeignKey("TuPedidoApi.Models.Construccion", "PozoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TuPedidoApi.Models.Customer", b =>
                {
                    b.HasOne("TuPedidoApi.Models.AppUser", "Identity")
                        .WithMany()
                        .HasForeignKey("IdentityId");
                });

            modelBuilder.Entity("TuPedidoApi.Models.Intervalo", b =>
                {
                    b.HasOne("TuPedidoApi.Models.Construccion")
                        .WithMany("Intervalos")
                        .HasForeignKey("ConstruccionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TuPedidoApi.Models.Partner", b =>
                {
                    b.HasOne("TuPedidoApi.Models.AppUser", "OwnerIdentity")
                        .WithMany()
                        .HasForeignKey("OwnerIdentityId");
                });
#pragma warning restore 612, 618
        }
    }
}
