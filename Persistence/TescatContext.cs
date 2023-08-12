using Beta_Tescat_0._1.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace Beta_Tescat_0._1.Persistence
{
    public class TescatContext : DbContext
    {
        public DbSet<User> Users => Set<User>();


        public TescatContext(
            DbContextOptions<TescatContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfig());

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Itzel Ameyalli Castro Castillo",
                    Office = "Ensenada",
                    Position = "Cuenta de Gastos",
                    Entry_Date = new DateTime(2003, 12, 25),
                    Telephone = 106,
                    Mobile = 6641754655,
                    Department = "Administracion",
                    Web_Privileges = true
                },
                new User
                {
                    Id = 2,
                    Name = "Marco Antonio Ramirez Perez",
                    Office = "Tijuana",
                    Position = "Comercializacion",
                    Entry_Date = new DateTime(2016, 03, 17),
                    Telephone = 133,
                    Mobile = 6469472236,
                    Department = "Administracion",
                    Web_Privileges = false
                });


        }

    }
}
