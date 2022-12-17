﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using zanfranceschi_challenge.Data;

#nullable disable

namespace zanfranceschichallenge.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221217043245_CreateClienteAndSaldo")]
    partial class CreateClienteAndSaldo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("zanfranceschi_challenge.Models.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("SaldoId")
                        .HasColumnType("uuid");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SaldoId")
                        .IsUnique();

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("zanfranceschi_challenge.Models.Saldo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("de")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("saldo")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Saldos");
                });

            modelBuilder.Entity("zanfranceschi_challenge.Models.Cliente", b =>
                {
                    b.HasOne("zanfranceschi_challenge.Models.Saldo", "Saldo")
                        .WithOne("Cliente")
                        .HasForeignKey("zanfranceschi_challenge.Models.Cliente", "SaldoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Saldo");
                });

            modelBuilder.Entity("zanfranceschi_challenge.Models.Saldo", b =>
                {
                    b.Navigation("Cliente")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
