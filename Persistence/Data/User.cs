using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Beta_Tescat_0._1.Persistence.Data
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = default!;

        [Required]
        [StringLength(50)]
        public string Department { get; set; } = default!;

        [StringLength(50)]
        public string? Office { get; set; } = default!;

        [Required]
        [StringLength(50)]
        public string Position { get; set; } = default!;

        [Required]
        public DateTime Entry_Date { get; set; }

        public DateTime Last_Working_Date { get; set; }

        public int Telephone { get; set; }

        public long Mobile { get; set; }

        public List<UserEmails> Emails { get; set; } = new List<UserEmails>();

        public bool Web_Privileges { get; set; }
        public DateTime Last_Modif { get; set; }

        public string? Picture { get; set; }

    }

    public class UserEmails
    {
        public int Id { get; set; }
        public string UserEmail { get; set; } = default!;
        public int UserId { get; set; }
        public User User { get; set; } = default!;

    }
}
