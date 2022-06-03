using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mattermost.Bot.Api.DTO;

namespace Mattermost.Bot
{
    public class User
    {
        private UserDTO _dto;

        public User(UserDTO dto) {
            _dto = dto;
        }
    }
}