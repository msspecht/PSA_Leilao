﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TF_PSA.PL;

namespace TF_PSA.Migrations
{
    [DbContext(typeof(LeilaoContext))]
    [Migration("20200516191150_Adicionado mais propriedades a classe Item")]
    partial class AdicionadomaispropriedadesaclasseItem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TF_PSA.PL.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<string>("DescricaoBreve")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescricaoCompleta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Imagem")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("LeilaoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemId");

                    b.HasIndex("LeilaoId");

                    b.ToTable("Itens");
                });

            modelBuilder.Entity("TF_PSA.PL.Lance", b =>
                {
                    b.Property<int>("LanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LeilaoId")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("LanceId");

                    b.HasIndex("LeilaoId");

                    b.ToTable("Lances");
                });

            modelBuilder.Entity("TF_PSA.PL.Leilao", b =>
                {
                    b.Property<int>("LeilaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IdUsuarioResponsavel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LanceAberto")
                        .HasColumnType("bit");

                    b.Property<DateTime>("dataFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dataInicio")
                        .HasColumnType("datetime2");

                    b.HasKey("LeilaoId");

                    b.ToTable("Leiloes");
                });

            modelBuilder.Entity("TF_PSA.PL.Usuario", b =>
                {
                    b.Property<string>("UsuarioId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("TF_PSA.PL.Item", b =>
                {
                    b.HasOne("TF_PSA.PL.Leilao", null)
                        .WithMany("Lote")
                        .HasForeignKey("LeilaoId");
                });

            modelBuilder.Entity("TF_PSA.PL.Lance", b =>
                {
                    b.HasOne("TF_PSA.PL.Leilao", null)
                        .WithMany("Lances")
                        .HasForeignKey("LeilaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
