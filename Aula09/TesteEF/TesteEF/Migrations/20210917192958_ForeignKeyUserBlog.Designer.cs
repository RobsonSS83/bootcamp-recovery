﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteEF;

namespace TesteEF.Migrations
{
    [DbContext(typeof(TesteEFDBContext))]
    [Migration("20210917192958_ForeignKeyUserBlog")]
    partial class ForeignKeyUserBlog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TesteEF.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_BLOG")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedTimestamp")
                        .HasColumnType("datetime2")
                        .HasColumnName("DT_CREATED");

                    b.Property<int>("IdUser")
                        .HasColumnType("int")
                        .HasColumnName("ID_USER_BLOG");

                    b.Property<string>("Name")
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("DSC_BLOG");

                    b.HasKey("Id");

                    b.HasIndex("IdUser");

                    b.ToTable("TB_BLOG");
                });

            modelBuilder.Entity("TesteEF.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_USER")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("NM_USER");

                    b.HasKey("Id");

                    b.ToTable("TB_USER");
                });

            modelBuilder.Entity("TesteEF.Models.Blog", b =>
                {
                    b.HasOne("TesteEF.Models.User", "User")
                        .WithMany("Blogs")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TesteEF.Models.User", b =>
                {
                    b.Navigation("Blogs");
                });
#pragma warning restore 612, 618
        }
    }
}
