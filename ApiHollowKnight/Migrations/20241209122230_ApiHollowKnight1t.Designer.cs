﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiHollowKnight.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241209122230_ApiHollowKnight1t")]
    partial class ApiHollowKnight1t
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ApiHollowKnight.Models.Character", b =>
                {
                    b.Property<int>("CharactersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CharactersId"));

                    b.Property<string>("CharactersDescription")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)");

                    b.Property<string>("CharactersGender")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("varchar(12)");

                    b.Property<string>("CharactersName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<int>("CharactersSpeciesId")
                        .HasColumnType("int");

                    b.Property<int>("CharactersTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<decimal>("Health")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("ImagemUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PlacesId")
                        .HasColumnType("int");

                    b.HasKey("CharactersId");

                    b.HasIndex("CharactersSpeciesId");

                    b.HasIndex("CharactersTypeId");

                    b.HasIndex("PlacesId");

                    b.ToTable("Character");
                });

            modelBuilder.Entity("ApiHollowKnight.Models.CharacterSpecies", b =>
                {
                    b.Property<int>("CharactersSpeciesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CharactersSpeciesId"));

                    b.Property<string>("CharactersSpeciesDescription")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)");

                    b.Property<string>("CharactersSpeciesName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.HasKey("CharactersSpeciesId");

                    b.ToTable("CharacterSpecies");
                });

            modelBuilder.Entity("ApiHollowKnight.Models.CharacterType", b =>
                {
                    b.Property<int>("CharacterTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CharacterTypeId"));

                    b.Property<string>("NameCharacterType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("NameCharacterTypeDescription")
                        .IsRequired()
                        .HasMaxLength(140)
                        .HasColumnType("varchar(140)");

                    b.HasKey("CharacterTypeId");

                    b.ToTable("CharactersTypes");
                });

            modelBuilder.Entity("ApiHollowKnight.Models.Place", b =>
                {
                    b.Property<int>("PlaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PlaceId"));

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.HasKey("PlaceId");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("ApiHollowKnight.Models.Character", b =>
                {
                    b.HasOne("ApiHollowKnight.Models.CharacterSpecies", "CharacterSpecies")
                        .WithMany("Characters")
                        .HasForeignKey("CharactersSpeciesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiHollowKnight.Models.CharacterType", "CharacterType")
                        .WithMany("Characters")
                        .HasForeignKey("CharactersTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiHollowKnight.Models.Place", "Place")
                        .WithMany("Characters")
                        .HasForeignKey("PlacesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CharacterSpecies");

                    b.Navigation("CharacterType");

                    b.Navigation("Place");
                });

            modelBuilder.Entity("ApiHollowKnight.Models.CharacterSpecies", b =>
                {
                    b.Navigation("Characters");
                });

            modelBuilder.Entity("ApiHollowKnight.Models.CharacterType", b =>
                {
                    b.Navigation("Characters");
                });

            modelBuilder.Entity("ApiHollowKnight.Models.Place", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}
