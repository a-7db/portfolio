using portfolio.API.data;
using System.Text.Json;

namespace portfolio.API
{
    public class Portfolio
    {
        private readonly static Dictionary<string, string> _paths = new Dictionary<string, string> {
            {"HEAD", "API/head.json" },
            {"LOGO", "API/logo.json" },
            {"HOME", "API/home.json" },
            {"ABOUT", "API/about.json" },
            {"EDU", "API/education.json" },
            {"SKILLS", "API/skills.json" },
            {"PROJECTS", "API/projects.json" },
            {"FOOTER", "API/footer.json" }
        };

        public Head? head { get; private set; }
        public Logo? logo { get; private set; }
        public Home? home { get; private set; }
        public About? about { get; private set; }
        public Education? education { get; private set; }
        public Skills? skills { get; private set; }
        public Projects? projects { get; private set; }
        public Footer? footer { get; private set; }

        public Portfolio()
        {
            this.head = LoadData<Head>(_paths["HEAD"]);
            this.home = LoadData<Home>(_paths["HOME"]);
            this.logo = LoadData<Logo>(_paths["LOGO"]);
            this.about = LoadData<About>(_paths["ABOUT"]);
            this.education = LoadData<Education>(_paths["EDU"]);
            this.skills = LoadData<Skills>(_paths["SKILLS"]);
            this.projects = LoadData<Projects>(_paths["PROJECTS"]);
            this.footer = LoadData<Footer>(_paths["FOOTER"]);
        }

        private T LoadData<T>(string path)
        {
            string json = File.ReadAllText(path);
            T? obj = JsonSerializer.Deserialize<T>(json);
            return obj;
        }
    }

}
