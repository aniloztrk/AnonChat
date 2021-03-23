using Rocket.API;

namespace AnonymousChat
{
    public class Config : IRocketPluginConfiguration
    {
        public string Format, ImgUrl;
        public void LoadDefaults()
        {
            Format = "{color=yellow}[Anon]:{/color} %MESSAGE%";
            ImgUrl = "";
        }
    }
}
