using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AspNetCore.Simple.Models;

namespace AspNetCore.Simple.Migrations
{
    [DbContext(typeof(UsersContext))]
    [Migration("20170328014203_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspNetCore.Simple.Models.Users", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Mail");

                    b.Property<string>("PassWord");

                    b.Property<string>("Phone");

                    b.Property<string>("UserName");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });
        }
    }
}
