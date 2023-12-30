namespace portfolio.API.data
{
    public class AboutObj
    {
        public About? about { get; set; }
    }

    public class About
    {
        public string? heading { get; set; }
        public string? in_span { get; set; }
        public string? avatar { get; set; }
        public string? industry { get; set; }
        public string? about_me { get; set; }
        public About_Btn? about_btn { get; set; }
    }

    public class About_Btn
    {
        public string? text { get; set; }
        public string? link { get; set; }
    }

}
