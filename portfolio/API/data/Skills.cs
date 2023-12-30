namespace portfolio.API.data
{
    public class Skills
    {
        public string? heading { get; set; }
        public string? in_span { get; set; }
        public string? text { get; set; }
        public Box_List[]? box_list { get; set; }
    }

    public class Box_List
    {
        public string? title { get; set; }
        public Skill_List[]? skill_list { get; set; }
    }

    public class Skill_List
    {
        public string? skill_name { get; set; }
        public string? icon { get; set; }
    }

}
