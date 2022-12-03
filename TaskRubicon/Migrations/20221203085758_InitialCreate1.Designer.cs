﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskRubicon.Data;

#nullable disable

namespace TaskRubicon.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221203085758_InitialCreate1")]
    partial class InitialCreate1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TaskRubicon.Models.BlogPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BlogPosts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Body = "The app is simple to use, and will help you decide on your best furniture fit.",
                            Description = "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.",
                            Slug = "augmented-reality-ios-application",
                            Title = "Augmented Reality iOS Application",
                            createdAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4304),
                            updatedAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4305)
                        },
                        new
                        {
                            Id = 2,
                            Body = "The app is simple to use, and will help you decide on your best furniture fit.",
                            Description = "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.",
                            Slug = "augmented-reality-ios-application-2",
                            Title = "Augmented Reality iOS Application 2",
                            createdAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4328),
                            updatedAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4328)
                        },
                        new
                        {
                            Id = 3,
                            Body = "The app is simple to use.",
                            Description = "Rubicon Software Development and Gazzda furniture are proud to launch an java app.",
                            Slug = "java-application",
                            Title = "Java application",
                            createdAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4337),
                            updatedAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4337)
                        },
                        new
                        {
                            Id = 4,
                            Body = "The app is suitable for beginners.",
                            Description = "Faculty of Electrical Engineering Sarajevo is proud to launch an console app.",
                            Slug = "console-application-for-students",
                            Title = "Console application for students!",
                            createdAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4345),
                            updatedAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4345)
                        },
                        new
                        {
                            Id = 5,
                            Body = "The app is very interesting.",
                            Description = "A young student is proud to launch an android app.",
                            Slug = "android-application",
                            Title = "Android application",
                            createdAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4354),
                            updatedAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4354)
                        });
                });

            modelBuilder.Entity("TaskRubicon.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BlogPostId")
                        .HasColumnType("int");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BlogPostId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BlogPostId = 1,
                            Body = "Great blog.",
                            createdAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4473),
                            updatedAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4474)
                        },
                        new
                        {
                            Id = 2,
                            BlogPostId = 1,
                            Body = "Very nice blog",
                            createdAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4484),
                            updatedAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4484)
                        },
                        new
                        {
                            Id = 3,
                            BlogPostId = 1,
                            Body = "Wonderful blog.",
                            createdAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4491),
                            updatedAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4492)
                        },
                        new
                        {
                            Id = 4,
                            BlogPostId = 2,
                            Body = "Woow",
                            createdAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4649),
                            updatedAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4649)
                        },
                        new
                        {
                            Id = 5,
                            BlogPostId = 3,
                            Body = "Amazing",
                            createdAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4676),
                            updatedAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4676)
                        },
                        new
                        {
                            Id = 6,
                            BlogPostId = 3,
                            Body = "I love it!",
                            createdAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4685),
                            updatedAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4686)
                        },
                        new
                        {
                            Id = 7,
                            BlogPostId = 4,
                            Body = "The best app ever!",
                            createdAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4693),
                            updatedAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4693)
                        },
                        new
                        {
                            Id = 8,
                            BlogPostId = 4,
                            Body = "I don't like it!",
                            createdAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4701),
                            updatedAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4701)
                        },
                        new
                        {
                            Id = 9,
                            BlogPostId = 5,
                            Body = "I don't like it!",
                            createdAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4708),
                            updatedAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4708)
                        },
                        new
                        {
                            Id = 10,
                            BlogPostId = 5,
                            Body = "One of the best apps i ever had",
                            createdAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4716),
                            updatedAt = new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4716)
                        });
                });

            modelBuilder.Entity("TaskRubicon.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BlogPostId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BlogPostId");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BlogPostId = 1,
                            Title = "iOS"
                        },
                        new
                        {
                            Id = 2,
                            BlogPostId = 1,
                            Title = "AR"
                        },
                        new
                        {
                            Id = 3,
                            BlogPostId = 2,
                            Title = "Gazzda"
                        },
                        new
                        {
                            Id = 4,
                            BlogPostId = 2,
                            Title = "AR"
                        },
                        new
                        {
                            Id = 5,
                            BlogPostId = 2,
                            Title = "iOS"
                        },
                        new
                        {
                            Id = 6,
                            BlogPostId = 3,
                            Title = "Java"
                        },
                        new
                        {
                            Id = 7,
                            BlogPostId = 3,
                            Title = "React"
                        },
                        new
                        {
                            Id = 8,
                            BlogPostId = 4,
                            Title = "React"
                        },
                        new
                        {
                            Id = 9,
                            BlogPostId = 4,
                            Title = "ASP.NET"
                        },
                        new
                        {
                            Id = 10,
                            BlogPostId = 4,
                            Title = "Postman"
                        },
                        new
                        {
                            Id = 11,
                            BlogPostId = 5,
                            Title = "Kotlin"
                        },
                        new
                        {
                            Id = 12,
                            BlogPostId = 5,
                            Title = "Flutter"
                        },
                        new
                        {
                            Id = 13,
                            BlogPostId = 5,
                            Title = "Postman"
                        });
                });

            modelBuilder.Entity("TaskRubicon.Models.Comment", b =>
                {
                    b.HasOne("TaskRubicon.Models.BlogPost", "BlogPost")
                        .WithMany("BlogPostComments")
                        .HasForeignKey("BlogPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BlogPost");
                });

            modelBuilder.Entity("TaskRubicon.Models.Tag", b =>
                {
                    b.HasOne("TaskRubicon.Models.BlogPost", "BlogPost")
                        .WithMany("TagList")
                        .HasForeignKey("BlogPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BlogPost");
                });

            modelBuilder.Entity("TaskRubicon.Models.BlogPost", b =>
                {
                    b.Navigation("BlogPostComments");

                    b.Navigation("TagList");
                });
#pragma warning restore 612, 618
        }
    }
}
