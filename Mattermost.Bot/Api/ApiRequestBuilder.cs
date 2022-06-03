using System.Net.Http;

namespace Mattermost.Bot.Api
{   
    public class ApiBuilder
    {
        private string _host;

        public ApiBuilder(string host) 
        {
            _host = $"https://{host}/api/v4";
        }   

        public HttpRequestMessage ping() 
        {
            return new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{_host}/ping")
            };
        }

        public PostsApiRequest posts() 
        {
            return new PostsApiRequest(_host+"/posts");
        }

        public ChannelsApiRequest channels() 
        {
            return new ChannelsApiRequest(_host+"/channels");
        }

        public FilesApiRequest files() 
        {
            return new FilesApiRequest(_host+"/files");
        }

        public TeamsApiRequest teams() 
        {
            return new TeamsApiRequest(_host+"/teams");
        }

        public ReactionApiRequest reactions() 
        {
            return new ReactionApiRequest(_host);
        }
    }
}