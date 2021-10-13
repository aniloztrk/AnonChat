using Rocket.API;
using Rocket.Unturned.Chat;
using SDG.Unturned;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace AnonymousChat
{
    public class Command : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Both;

        public string Name => "anonchat";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string> { "ac", "gizlisohbet" };

        public List<string> Permissions => new List<string> { "mixy.anonymouschat", "mixy.anonchat"};

        public void Execute(IRocketPlayer caller, string[] command)
        {
            string message = string.Join(" ", command);
            var c = Main.Instance.Configuration.Instance;
            string format = c.Format.Replace('{', '<').Replace('}', '>').Replace("%MESSAGE%", message);
            if (command.Lenght == 0)
            {
                UnturnedChat.Say(caller, "Usage : /anonchat <message> (or /ac <message>)", Color.red);
                return;               
            }
            ChatManager.serverSendMessage(format, Color.white, null, null, EChatMode.SAY, c.ImgUrl, true);
        }
    }
}
