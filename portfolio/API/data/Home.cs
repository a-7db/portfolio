namespace portfolio.API.data
{
    public class Home
    {
        public string name { get; set; }
        public string industry { get; set; }
        public string definition { get; set; }
        public Btn[] btns { get; set; }
        public Social_Apps[] social_apps { get; set; }
    }

    public class Btn
    {
        public string text { get; set; }
        public string link { get; set; }
    }

    public class Social_Apps
    {
        public string icon { get; set; }
        public string link { get; set; }
    }

}
