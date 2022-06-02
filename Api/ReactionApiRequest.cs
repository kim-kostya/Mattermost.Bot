using System.Net.Http;
using Newtonsoft.Json;
using Mattermost.Bot.Api.DTO;


namespace Mattermost.Bot.Api
{
    public class ReactionApiRequest
    {
        private string _host;

        public ReactionApiRequest(string host) {
            _host = host;
        }

        public HttpRequestMessage AddReaction(ReactionDTO reaction) {
            var message = new HttpRequestMessage {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_host}/reactions")
            };

            message.Content = new StringContent(JsonConvert.SerializeObject(reaction));

            return message;
        }

        public HttpRequestMessage GetRactions(string postId) {
            var message = new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{_host}/posts/{postId}/reactions")
            };

            return message;
        }

        public HttpRequestMessage RemoveReaction(ReactionDTO reaction) {
            var message = new HttpRequestMessage {
                Method = HttpMethod.Delete,
                RequestUri = new Uri($"{_host}/users/{reaction.UserId}/posts/{reaction.PostId}/reaction/{reaction.EmojiName}")
            };

            return message;
        }
        
    }
}