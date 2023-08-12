using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Beta_Tescat_0._1.Persistence.Data
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; } = default!; 

        public string Department { get; set; } = default!;

        public string Office { get; set; } = default!;

        public string Position { get; set; } = default!;

        public DateTime Entry_Date { get; set; }

        public DateTime Last_Working_Date { get; set; }

        public int Telephone { get; set; }

        public long Mobile { get; set; }

        public bool Web_Privileges { get; set; }

        public DateTime Last_Modif { get; set; }

        public string? Picture { get; set; }

    }

    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Department).IsRequired();
            builder.Property(x => x.Office).IsRequired();
            builder.Property(x => x.Position).IsRequired();
            builder.Property(x => x.Entry_Date).IsRequired();
            builder.Property(x => x.Last_Working_Date).IsRequired();
            builder.Property(x => x.Telephone).IsRequired();
            builder.Property(x => x.Mobile).IsRequired();
            builder.Property(x => x.Web_Privileges).IsRequired();
            builder.Property(x => x.Last_Modif).IsRequired();
        }


    }


}
