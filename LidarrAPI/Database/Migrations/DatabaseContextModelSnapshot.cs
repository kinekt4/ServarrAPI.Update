﻿// <auto-generated />
using LidarrAPI.Database;
using LidarrAPI.Update;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace LidarrAPI.Database.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("LidarrAPI.Database.Models.TraktEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<Guid>("State");

                    b.Property<string>("Target");

                    b.HasKey("Id");

                    b.HasIndex("State");

                    b.ToTable("Trakt");
                });

            modelBuilder.Entity("LidarrAPI.Database.Models.UpdateEntity", b =>
                {
                    b.Property<int>("UpdateEntityId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Branch");

                    b.Property<string>("FixedStr")
                        .HasColumnName("Fixed");

                    b.Property<string>("NewStr")
                        .HasColumnName("New");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Version")
                        .IsRequired();

                    b.HasKey("UpdateEntityId");

                    b.HasIndex("Branch", "Version")
                        .IsUnique();

                    b.ToTable("Updates");
                });

            modelBuilder.Entity("LidarrAPI.Database.Models.UpdateFileEntity", b =>
                {
                    b.Property<int>("UpdateEntityId");

                    b.Property<int>("OperatingSystem");

                    b.Property<string>("Filename");

                    b.Property<string>("Hash");

                    b.Property<string>("Url");

                    b.HasKey("UpdateEntityId", "OperatingSystem");

                    b.ToTable("UpdateFiles");
                });

            modelBuilder.Entity("LidarrAPI.Database.Models.UpdateFileEntity", b =>
                {
                    b.HasOne("LidarrAPI.Database.Models.UpdateEntity", "Update")
                        .WithMany("UpdateFiles")
                        .HasForeignKey("UpdateEntityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
