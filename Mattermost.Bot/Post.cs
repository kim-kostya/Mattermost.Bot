using Mattermost.Bot.Api.DTO;
using Mattermost.Bot.Api;

namespace Mattermost.Bot
{
    public class Post
    {
        private PostDTO _dto;

        public string Id {
            get {
                return _dto.Id;
            }
        }

        public string Message {
            get {
                return _dto.Message;
            }
            set {
                _dto.Message = value;
            }
        }

        public Post(PostDTO _dto) 
        {

        }
    }
}