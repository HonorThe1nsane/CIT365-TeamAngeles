// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SaramentMeetingPlanner.Data;

#nullable disable

namespace SaramentMeetingPlanner.Migrations
{
    [DbContext(typeof(SaramentMeetingPlannerContext))]
    [Migration("20221211041756_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SaramentMeetingPlanner.Models.Planner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClosingHymnNum")
                        .HasColumnType("int");

                    b.Property<string>("ClosingHymnTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClosingPrayer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConductingLeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("IntermediateNum")
                        .HasColumnType("int");

                    b.Property<string>("IntermediateTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfSpeakers")
                        .HasColumnType("int");

                    b.Property<string>("OpeningPrayer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningSongNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningSongTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SacramentHymn")
                        .HasColumnType("int");

                    b.Property<string>("SacramentHymnTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpeakerSubjects")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Planner");
                });
#pragma warning restore 612, 618
        }
    }
}
