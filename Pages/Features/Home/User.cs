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

        public string Entry_Date { get; set; } = "";

        public int Telephone { get; set; }

        public int Web_Privileges { get; set; }

        public string Picture { get; set; } = "";



    }
}
