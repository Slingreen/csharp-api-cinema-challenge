﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api_cinema_challenge.Data;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    [DbContext(typeof(CinemaContext))]
    [Migration("20240208093914_test3")]
    partial class test3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api_cinema_challenge.Models.DatabaseModels.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("customer_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone");

                    b.Property<DateTime>("UpdateddAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2017, 2, 8, 23, 0, 0, 0, DateTimeKind.Utc),
                            Email = "Jimi Hepburn@gmail.com",
                            Name = "Jimi Hepburn",
                            Phone = "38817016",
                            UpdateddAt = new DateTime(2017, 2, 8, 23, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2005, 9, 19, 22, 0, 0, 0, DateTimeKind.Utc),
                            Email = "Kate Hepburn@gmail.com",
                            Name = "Kate Hepburn",
                            Phone = "91269957",
                            UpdateddAt = new DateTime(2005, 9, 19, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2013, 8, 5, 22, 0, 0, 0, DateTimeKind.Utc),
                            Email = "Donald Winfrey@asl.com",
                            Name = "Donald Winfrey",
                            Phone = "76968515",
                            UpdateddAt = new DateTime(2013, 8, 5, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2003, 3, 3, 23, 0, 0, 0, DateTimeKind.Utc),
                            Email = "Elvis Hepburn@outlook.com",
                            Name = "Elvis Hepburn",
                            Phone = "46765564",
                            UpdateddAt = new DateTime(2003, 3, 3, 23, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2001, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc),
                            Email = "Elvis Winslet@msn.com",
                            Name = "Elvis Winslet",
                            Phone = "94747900",
                            UpdateddAt = new DateTime(2001, 9, 30, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2021, 4, 24, 22, 0, 0, 0, DateTimeKind.Utc),
                            Email = "Oprah Hendrix@hotmail.com",
                            Name = "Oprah Hendrix",
                            Phone = "87687560",
                            UpdateddAt = new DateTime(2021, 4, 24, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2019, 3, 16, 23, 0, 0, 0, DateTimeKind.Utc),
                            Email = "Audrey Middleton@outlook.com",
                            Name = "Audrey Middleton",
                            Phone = "82411835",
                            UpdateddAt = new DateTime(2019, 3, 16, 23, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2000, 6, 9, 22, 0, 0, 0, DateTimeKind.Utc),
                            Email = "Kate Trump@hotmail.com",
                            Name = "Kate Trump",
                            Phone = "87879749",
                            UpdateddAt = new DateTime(2000, 6, 9, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2006, 5, 6, 22, 0, 0, 0, DateTimeKind.Utc),
                            Email = "Jimi Windsor@outlook.com",
                            Name = "Jimi Windsor",
                            Phone = "89402772",
                            UpdateddAt = new DateTime(2006, 5, 6, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2022, 8, 19, 22, 0, 0, 0, DateTimeKind.Utc),
                            Email = "Donald Presley@gmail.com",
                            Name = "Donald Presley",
                            Phone = "22961001",
                            UpdateddAt = new DateTime(2022, 8, 19, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2015, 7, 22, 22, 0, 0, 0, DateTimeKind.Utc),
                            Email = "Audrey Winfrey@msn.com",
                            Name = "Audrey Winfrey",
                            Phone = "85338748",
                            UpdateddAt = new DateTime(2015, 7, 22, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2008, 7, 9, 22, 0, 0, 0, DateTimeKind.Utc),
                            Email = "Oprah Hepburn@msn.com",
                            Name = "Oprah Hepburn",
                            Phone = "77616214",
                            UpdateddAt = new DateTime(2008, 7, 9, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 13,
                            CreatedAt = new DateTime(2001, 8, 3, 22, 0, 0, 0, DateTimeKind.Utc),
                            Email = "Kate Winslet@gmail.com",
                            Name = "Kate Winslet",
                            Phone = "79655669",
                            UpdateddAt = new DateTime(2001, 8, 3, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 14,
                            CreatedAt = new DateTime(2008, 6, 7, 22, 0, 0, 0, DateTimeKind.Utc),
                            Email = "Donald Presley@asl.com",
                            Name = "Donald Presley",
                            Phone = "35488557",
                            UpdateddAt = new DateTime(2008, 6, 7, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 15,
                            CreatedAt = new DateTime(2008, 9, 26, 22, 0, 0, 0, DateTimeKind.Utc),
                            Email = "Mick Obama@asl.com",
                            Name = "Mick Obama",
                            Phone = "45191971",
                            UpdateddAt = new DateTime(2008, 9, 26, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 16,
                            CreatedAt = new DateTime(2012, 1, 5, 23, 0, 0, 0, DateTimeKind.Utc),
                            Email = "Barack Presley@hotmail.com",
                            Name = "Barack Presley",
                            Phone = "75086901",
                            UpdateddAt = new DateTime(2012, 1, 5, 23, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 17,
                            CreatedAt = new DateTime(2010, 2, 5, 23, 0, 0, 0, DateTimeKind.Utc),
                            Email = "Jimi Winslet@gmail.com",
                            Name = "Jimi Winslet",
                            Phone = "50770370",
                            UpdateddAt = new DateTime(2010, 2, 5, 23, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 18,
                            CreatedAt = new DateTime(2020, 2, 10, 23, 0, 0, 0, DateTimeKind.Utc),
                            Email = "Jimi Windsor@msn.com",
                            Name = "Jimi Windsor",
                            Phone = "30368411",
                            UpdateddAt = new DateTime(2020, 2, 10, 23, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 19,
                            CreatedAt = new DateTime(2008, 1, 8, 23, 0, 0, 0, DateTimeKind.Utc),
                            Email = "Elvis Hepburn@gmail.com",
                            Name = "Elvis Hepburn",
                            Phone = "94779233",
                            UpdateddAt = new DateTime(2008, 1, 8, 23, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.DatabaseModels.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("movie_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("rating");

                    b.Property<int>("Runtime")
                        .HasColumnType("integer")
                        .HasColumnName("runtime");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdateddAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2012, 1, 1, 23, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Sci-Fi Sci-Fi",
                            Rating = "PPG-13 – Parents Strongly Cautioned",
                            Runtime = 195,
                            Title = "A herd of Transparent Houses",
                            UpdateddAt = new DateTime(2012, 1, 1, 23, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2010, 5, 4, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Sci-Fi Dwarf",
                            Rating = "PPG-13 – Parents Strongly Cautioned",
                            Runtime = 77,
                            Title = "A herd of Microscopic Houses",
                            UpdateddAt = new DateTime(2010, 5, 4, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2016, 5, 10, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Romance Sci-Fi",
                            Rating = "PPG-13 – Parents Strongly Cautioned",
                            Runtime = 201,
                            Title = "A herd of Purple Planets",
                            UpdateddAt = new DateTime(2016, 5, 10, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2017, 8, 1, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Comedy Dwarf",
                            Rating = "NC-17 – Adults Only",
                            Runtime = 168,
                            Title = "A herd of Large Flowers",
                            UpdateddAt = new DateTime(2017, 8, 1, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2021, 5, 20, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Comedy Space",
                            Rating = "PPG-13 – Parents Strongly Cautioned",
                            Runtime = 201,
                            Title = "Fifteen Large Houses",
                            UpdateddAt = new DateTime(2021, 5, 20, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2021, 6, 4, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Space Western",
                            Rating = "G – General Audiences",
                            Runtime = 75,
                            Title = "An army of Green Leopards",
                            UpdateddAt = new DateTime(2021, 6, 4, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2006, 5, 20, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Western Space",
                            Rating = "PPG-13 – Parents Strongly Cautioned",
                            Runtime = 132,
                            Title = "Two Bitter Buildings",
                            UpdateddAt = new DateTime(2006, 5, 20, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2010, 2, 3, 23, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Fantasy Pirate",
                            Rating = "R – Restricted",
                            Runtime = 235,
                            Title = "A bunch of Green Buildings",
                            UpdateddAt = new DateTime(2010, 2, 3, 23, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2000, 8, 18, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Dwarf Cyberpunk",
                            Rating = "R – Restricted",
                            Runtime = 204,
                            Title = "Two Orange Leopards",
                            UpdateddAt = new DateTime(2000, 8, 18, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2019, 2, 24, 23, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Sci-Fi Cyberpunk",
                            Rating = "PPG-13 – Parents Strongly Cautioned",
                            Runtime = 124,
                            Title = "An army of Orange Buildings",
                            UpdateddAt = new DateTime(2019, 2, 24, 23, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2011, 10, 12, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Cyberpunk Pirate",
                            Rating = "R – Restricted",
                            Runtime = 146,
                            Title = "A bunch of Green Planets",
                            UpdateddAt = new DateTime(2011, 10, 12, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2022, 8, 3, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Western Comedy",
                            Rating = "PG – Parental Guidance Suggested",
                            Runtime = 121,
                            Title = "The Transparent Houses",
                            UpdateddAt = new DateTime(2022, 8, 3, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 13,
                            CreatedAt = new DateTime(2005, 6, 10, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Fantasy Dwarf",
                            Rating = "NC-17 – Adults Only",
                            Runtime = 179,
                            Title = "Several Large Leopards",
                            UpdateddAt = new DateTime(2005, 6, 10, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 14,
                            CreatedAt = new DateTime(2021, 3, 13, 23, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Dwarf Historic",
                            Rating = "NC-17 – Adults Only",
                            Runtime = 199,
                            Title = "Two Purple Cars",
                            UpdateddAt = new DateTime(2021, 3, 13, 23, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 15,
                            CreatedAt = new DateTime(2017, 9, 10, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Dwarf Space",
                            Rating = "G – General Audiences",
                            Runtime = 195,
                            Title = "A bunch of Purple Buildings",
                            UpdateddAt = new DateTime(2017, 9, 10, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 16,
                            CreatedAt = new DateTime(2001, 11, 23, 23, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Sci-Fi Western",
                            Rating = "NC-17 – Adults Only",
                            Runtime = 118,
                            Title = "Several Green Cars",
                            UpdateddAt = new DateTime(2001, 11, 23, 23, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 17,
                            CreatedAt = new DateTime(2008, 4, 7, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Cyberpunk Comedy",
                            Rating = "PPG-13 – Parents Strongly Cautioned",
                            Runtime = 169,
                            Title = "The Green Houses",
                            UpdateddAt = new DateTime(2008, 4, 7, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 18,
                            CreatedAt = new DateTime(2008, 8, 8, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Adventure Space",
                            Rating = "PPG-13 – Parents Strongly Cautioned",
                            Runtime = 221,
                            Title = "Fifteen Purple Cars",
                            UpdateddAt = new DateTime(2008, 8, 8, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 19,
                            CreatedAt = new DateTime(2009, 9, 4, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Historic Pirate",
                            Rating = "R – Restricted",
                            Runtime = 168,
                            Title = "Two Purple Planets",
                            UpdateddAt = new DateTime(2009, 9, 4, 22, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.DatabaseModels.Screening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("screening_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("integer")
                        .HasColumnName("capacity");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer")
                        .HasColumnName("movie_id");

                    b.Property<int>("ScreenNumber")
                        .HasColumnType("integer")
                        .HasColumnName("screen_number");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("starts_at");

                    b.Property<DateTime>("UpdateddAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Screenings");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.DatabaseModels.Screening", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.DatabaseModels.Movie", null)
                        .WithMany("Screenings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("api_cinema_challenge.Models.DatabaseModels.Movie", b =>
                {
                    b.Navigation("Screenings");
                });
#pragma warning restore 612, 618
        }
    }
}
