namespace Beta_Tescat_0._1.Pages.Features.Home

{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; } = ""; public string FormattedName
        {
            get
            {
                if (!string.IsNullOrEmpty(Name))
                {
                    var names = Name.Split(' ');
                    if (names.Length >= 2)
                    {
                        return $"{names[0]} {names[1]}";
                    }
                }
                return Name;
            }
        }

        public string Department { get; set; } = "";

        public string Office { get; set; } = "";

        public string Position { get; set; } = "";

        public DateTime Entry_Date { get; set; }

        public DateTime Last_Working_Date { get; set; }

        public int Telephone { get; set; }

        public long Mobile { get; set; }

        public bool Web_Privileges { get; set; }

        public DateTime Last_Modif { get; set; }
        
        public string Picture { get; set; } = "";
    }
}
