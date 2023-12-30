namespace portfolio.API.data
{
    public class Projects
    {
        public string? heading { get; set; }
        public Proj_List[]? proj_list { get; set; }
    }

    public class Proj_List
    {
        public int? proj_ID { get; set; }
        public string? img { get; set; }
        public string[]? tags { get; set; }
        public string? title { get; set; }
        public string? duration { get; set; }
        public string? desc { get; set; }
        public Partner? partner { get; set; }
        public Btn[]? btns { get; set; }
        public string? project_link { get; set; }
    }

    public class Partner
    {
        public string? name { get; set; }
        public string? img { get; set; }
        public string? github_account { get; set; }
    }

}
