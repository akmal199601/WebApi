// <auto-generated />
using System;
using Api.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Api.Migrations
{
    [DbContext(typeof(ApiContext))]
    partial class ApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Api.Models.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Quotes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "akmal199601",
                            InsertDate = new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "Волк не тот кто волк а тот кто волк тот волк"
                        },
                        new
                        {
                            Id = 2,
                            Author = "akmal1996",
                            InsertDate = new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "Девушка будет по-настоящему счастлива,когда у неё будет два счастья: одно будет говорить ″Любимая″,а второе — ″Мама″"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Khurshed",
                            InsertDate = new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "Учись мой уный падаван"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Mr Azizojon",
                            InsertDate = new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "А на собеседовании что будишь делать "
                        },
                        new
                        {
                            Id = 5,
                            Author = "Azizov Akmal",
                            InsertDate = new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "Обычно, девочки любят куколок, а мальчики — красивые машинки. Но это только до 17 лет. А потом всё становится наоборот "
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
