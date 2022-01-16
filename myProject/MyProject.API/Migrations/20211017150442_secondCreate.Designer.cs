﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyProject.API.Infra;

namespace MyProject.API.Migrations
{
    [DbContext(typeof(EventContext))]
    [Migration("20211017150442_secondCreate")]
    partial class secondCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("MyProject.API.Domain.Event", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("eventAge")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("eventDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("eventDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("eventParticipants")
                        .HasColumnType("TEXT");

                    b.Property<int>("eventParticpantCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("eventTitle")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("MyProject.API.Domain.User", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("userBirthdate")
                        .HasColumnType("TEXT");

                    b.Property<string>("userEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("userName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
