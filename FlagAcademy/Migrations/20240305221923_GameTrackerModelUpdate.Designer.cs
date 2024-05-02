﻿// <auto-generated />
using FlagAcademy.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FlagAcademy.Migrations
{
    [DbContext(typeof(FlagAcademyContext))]
    [Migration("20240305221923_GameTrackerModelUpdate")]
    partial class GameTrackerModelUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FlagAcademy.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Flag")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("flag");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_countries");

                    b.ToTable("countries", (string)null);
                });

            modelBuilder.Entity("FlagAcademy.Models.GameTracker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CurrentQuestion")
                        .HasColumnType("integer")
                        .HasColumnName("current_question");

                    b.Property<int>("GameLength")
                        .HasColumnType("integer")
                        .HasColumnName("game_length");

                    b.Property<string>("Score")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("score");

                    b.HasKey("Id")
                        .HasName("pk_game_trackers");

                    b.ToTable("game_trackers", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
