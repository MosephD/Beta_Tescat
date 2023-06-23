namespace Beta_Tescat_0._1.Features.Home
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Department { get; set; } = "";

        public string Picture { get; set; } = "";

        public string Position { get; set; } = "";

        public DateTime Entry_Date { get; set; } 
            public string FormattedDate => Entry_Date.ToString("yyyy-MM-dd");


        public int Telephone { get; set; }

        public IEnumerable<UserDetails> Route { get; set; } = Array.Empty<UserDetails>();


        public class UserDetails
        {
            public int Name { get; set; }
            public string Web_Privileges { get; set; } = "";
        }





    }
}
}
