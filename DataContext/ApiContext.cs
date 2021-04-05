using Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DataContext
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions options) : base(options)
        {
            Database.Migrate();
        }

        protected ApiContext()
        {
        }
        public DbSet<Quote> Quotes { get; set; }
        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Quote>().HasData(
                new Quote()
                {
                    Id = 1,
                    Text = "Волк не тот кто волк а тот кто волк тот волк",
                    Author = "akmal199601",
                    InsertDate = DateTime.Parse("05-05-2021"),

                },
                new Quote()
                {
                    Id = 2,
                    Text = "Девушка будет по-настоящему счастлива,когда у неё будет два счастья: одно будет говорить ″Любимая″,а второе — ″Мама″",
                    Author = "akmal1996",
                    InsertDate = DateTime.Parse("05-05-2021")

                },
                new Quote()
                {
                    Id = 3,
                    Text = "Учись мой уный падаван",
                    Author = "Khurshed",
                    InsertDate = DateTime.Parse("05-05-2021")
                },
                new Quote()
                {
                    Id = 4,
                    Text = "А на собеседовании что будишь делать ",
                    Author = "Mr Azizojon",
                    InsertDate = DateTime.Parse("05-05-2021")

                },
                new Quote()
                {
                    Id = 5,
                    Text = "Обычно, девочки любят куколок, а мальчики — красивые машинки. Но это только до 17 лет. А потом всё становится наоборот ",
                    Author = "Azizov Akmal",
                    InsertDate = DateTime.Parse("05-05-2021")
                }
                );
        }
    }
}