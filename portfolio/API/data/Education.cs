namespace portfolio.API.data
{

    public class Education
    {
        public string? heading { get; set; }
        public string? in_span { get; set; }
        public My_Edu? my_edu { get; set; }
        public My_Courses? my_courses { get; set; }
    }

    public class My_Edu
    {
        public string? heading { get; set; }
        public Edu_List[]? edu_list { get; set; }
    }

    public class Edu_List
    {
        public string? duration { get; set; }
        public string? level { get; set; }
        public string? desc { get; set; }
    }

    public class My_Courses
    {
        public string? heading { get; set; }
        public Edu_List1[]? edu_list { get; set; }
    }

    public class Edu_List1
    {
        public string? duration { get; set; }
        public string? level { get; set; }
        public string? desc { get; set; }
    }

}
