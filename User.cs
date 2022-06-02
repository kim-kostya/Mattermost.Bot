using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mattermost.Bot
{
    public class User
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Nickname { get; set; }
        public string? Locale { get; set; }
        public string[] Roles { get; set; }
    }
}