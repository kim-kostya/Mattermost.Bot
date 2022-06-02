using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mattermost.Bot.Api.DTO;
using Newtonsoft.Json;

namespace Mattermost.Bot.Api
{
    public class ChannelsApiRequest
    {
        private string _host;
        
        public ChannelsApiRequest(string host) 
        {
            _host = host;
        }
        
        public HttpRequestMessage GetListOfChannels(ListOfChannelsRequestDTO request) 
        {
            var message = new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri(_host)
            };

            message.Content = new StringContent(JsonConvert.SerializeObject(request));

            return message;
        }

    }
}