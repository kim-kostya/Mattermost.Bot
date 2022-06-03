using Mattermost.Bot.Api.DTO;
using Newtonsoft.Json;

namespace Mattermost.Bot.Api
{
    public class TeamsApiRequest
    {
        private string _host;

        public TeamsApiRequest(string host) 
        {
            _host = host;
        }

        public HttpRequestMessage GetTeams(ListOfRequestDTO request) 
        {
            var message = new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri(_host)
            };

            message.Content = new StringContent(JsonConvert.SerializeObject(request));

            return message;
        }

        public HttpRequestMessage GetTeam(string teamId)
        {
            var message = new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{_host}/{teamId}")
            };

            return message;
        }
    }
}