using Microsoft.EntityFrameworkCore;
using Beta_Tescat_0._1.Persistence.Data;


namespace Beta_Tescat_0._1.Persistence
{
    public class TescatContext : DbContext
    {



        public TescatContext(
            DbContextOptions<TescatContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



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

            modelBuilder.Entity<UserEmails>().HasData(
                new UserEmails
                {
                    Id = 1,
                    UserEmail = "gastos.ens@grupoaceves.com",
                    UserId = 1,
                },
                new UserEmails
                {
                    Id = 2,
                    UserEmail = "m.ramirez@grupoaceves.com",
                    UserId = 2,
                });



            modelBuilder.Entity<UserEmails>()
            .HasOne(p => p.User)
            .WithMany(b => b.Emails)
            .HasForeignKey(p => p.UserId);
        }

    }
}
