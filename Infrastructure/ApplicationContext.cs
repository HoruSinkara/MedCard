using MedCard.Infrastructure.Models;

using Microsoft.EntityFrameworkCore;

namespace MedCard.Infrastructure
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Persen> persens { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persen>().HasData(new List<Persen>()
            {
                new() {Id = 1, Name="Акаккий", Surname="Акак", Patronumic="Аккакьевич",Birthday=DateTime.Now, Address="Улица Аккакия Акакова", Phone="89888888888", Anamnez="Рокрткчоркскачрчури", Gender="m", Post="jhvgbjh", WorkPlace="роморм"},
                new() {Id = 2, Name="JHGJHg", Surname="ftyj", Patronumic="jfyjyt",Birthday=DateTime.Now, Address="Улица Аккакия Акакова", Phone="89888888888", Anamnez="Рокрткчоркскачрчури", Gender="m", Post="jhvgbjh", WorkPlace="роморм"}

            });
        }
    }
}
