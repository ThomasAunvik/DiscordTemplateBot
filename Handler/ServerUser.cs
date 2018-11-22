using Discord.WebSocket;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hifumi_Bot
{
    [Serializable]
    public class ServerUser
    {
        public string username;
        public ulong userID;
        public bool isBot;

        public ServerUser(SocketGuildUser user)
        {
            if(user != null)
            {
                username = user.Username;
                userID = user.Id;
                isBot = user.IsBot;
            }
        }

        public void UpdateInfo(SocketGuildUser user)
        {
            if(user != null)
            {
                username = user.Username;
                userID = user.Id;
                isBot = user.IsBot;
            }
        }
    }
}
