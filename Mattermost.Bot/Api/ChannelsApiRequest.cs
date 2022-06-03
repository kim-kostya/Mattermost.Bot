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

        public HttpRequestMessage GetChannel(string channelId) {
            var message = new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{_host}/{channelId}")
            };

            return message;
        }

        public HttpRequestMessage UpdateChannel(ChannelDTO channel) {
            var message = new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{_host}/{channel.Id}")
            };

            message.Content = new StringContent(JsonConvert.SerializeObject(channel));

            return message;
        }

        public HttpRequestMessage CreateChannel(ChannelDTO channel) {
            var message = new HttpRequestMessage {
                Method = HttpMethod.Put,
                RequestUri = new Uri($"{_host}")
            };

            message.Content = new StringContent(JsonConvert.SerializeObject(channel));

            return message;
        }

        public HttpRequestMessage DeleteChannel(ChannelDTO channel) {
            var message = new HttpRequestMessage {
                Method = HttpMethod.Delete,
                RequestUri = new Uri($"{_host}/{channel.Id}")
            };

            return message;
        }

    }
}