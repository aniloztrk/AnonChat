using Rocket.Core.Plugins;

namespace AnonymousChat
{
    public class Main : RocketPlugin<Config>
    {
        public static Main Instance;
        protected override void Load()
        {
            Instance = this;
        }
        protected override void Unload()
        {
            Instance = null;
        }
    }
}
