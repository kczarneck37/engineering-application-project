﻿// <auto-generated />
using Inzynierka_Shop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Inzynierka_Shop.Migrations
{
    [DbContext(typeof(Inzynierka_ShopContext))]
    [Migration("20180916113924_new")]
    partial class @new
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Inzynierka_Shop.Models.Produkt", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cena");

                    b.Property<string>("Ilosc");

                    b.Property<string>("Kategoria");

                    b.Property<string>("Nazwa");

                    b.HasKey("ID");

                    b.ToTable("Produkt");
                });
#pragma warning restore 612, 618
        }
    }
}
