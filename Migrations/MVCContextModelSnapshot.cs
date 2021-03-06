﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MinhasCompras.Models;
using System;

namespace MinhasCompras.Migrations
{
    [DbContext(typeof(MVCContext))]
    partial class MVCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("MinhasCompras.Models.Item", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Checked");

                    b.Property<string>("Nome");

                    b.HasKey("ID");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("MinhasCompras.Models.Pessoa", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Nascimento");

                    b.Property<string>("Nome");

                    b.HasKey("ID");

                    b.ToTable("TbPessoa");
                });
#pragma warning restore 612, 618
        }
    }
}
