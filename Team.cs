using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mattermost.Bot
{
    public class Team
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string[] AllowedDomains { get; set; }
        public string InviteId { get; set; }
        public bool AllowOpenInvite { get; set; }
        public string PolicyId { get; set; }  
    }
}