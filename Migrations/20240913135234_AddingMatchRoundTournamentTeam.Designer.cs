﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Турнирная_сетка.Data;

#nullable disable

namespace Турнирная_сетка.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240913135234_AddingMatchRoundTournamentTeam")]
    partial class AddingMatchRoundTournamentTeam
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Турнирная_сетка.Entities.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("MatchTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("RoundId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("Team1Id")
                        .HasColumnType("int");

                    b.Property<int?>("Team2Id")
                        .HasColumnType("int");

                    b.Property<int?>("WinnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoundId");

                    b.HasIndex("Team1Id");

                    b.HasIndex("Team2Id");

                    b.HasIndex("WinnerId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("Турнирная_сетка.Entities.Round", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("RoundNumber")
                        .HasColumnType("int");

                    b.Property<int?>("TournamentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TournamentId");

                    b.ToTable("Rounds");
                });

            modelBuilder.Entity("Турнирная_сетка.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Discipline")
                        .HasColumnType("longtext");

                    b.Property<string>("LogoPath")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int?>("TournamentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TournamentId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Турнирная_сетка.Entities.Tournament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CurrentRound")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Tournaments");
                });

            modelBuilder.Entity("Турнирная_сетка.Entities.Match", b =>
                {
                    b.HasOne("Турнирная_сетка.Entities.Round", "Round")
                        .WithMany("Matches")
                        .HasForeignKey("RoundId");

                    b.HasOne("Турнирная_сетка.Entities.Team", "Team1")
                        .WithMany()
                        .HasForeignKey("Team1Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Турнирная_сетка.Entities.Team", "Team2")
                        .WithMany()
                        .HasForeignKey("Team2Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Турнирная_сетка.Entities.Team", "Winner")
                        .WithMany()
                        .HasForeignKey("WinnerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Round");

                    b.Navigation("Team1");

                    b.Navigation("Team2");

                    b.Navigation("Winner");
                });

            modelBuilder.Entity("Турнирная_сетка.Entities.Round", b =>
                {
                    b.HasOne("Турнирная_сетка.Entities.Tournament", null)
                        .WithMany("Rounds")
                        .HasForeignKey("TournamentId");
                });

            modelBuilder.Entity("Турнирная_сетка.Entities.Team", b =>
                {
                    b.HasOne("Турнирная_сетка.Entities.Tournament", null)
                        .WithMany("Teams")
                        .HasForeignKey("TournamentId");
                });

            modelBuilder.Entity("Турнирная_сетка.Entities.Round", b =>
                {
                    b.Navigation("Matches");
                });

            modelBuilder.Entity("Турнирная_сетка.Entities.Tournament", b =>
                {
                    b.Navigation("Rounds");

                    b.Navigation("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
