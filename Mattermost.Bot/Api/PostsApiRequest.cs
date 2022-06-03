using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Mattermost.Bot.Api.DTO;

namespace Mattermost.Bot.Api
{
    public class PostsApiRequest
    {
        private string _host;

        public PostsApiRequest(string host) {
            _host = host;
        }

        public HttpRequestMessage Send(PostDTO post) {
            var message = new HttpRequestMessage {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_host}")
            };

            message.Content = new StringContent(JsonConvert.SerializeObject(post));

            return message;
        }

        public HttpRequestMessage SendEphemeral(UserDTO user, PostDTO post) {
            var message = new HttpRequestMessage {
                Method = HttpMethod.Put,
                RequestUri = new Uri($"{_host}")
            };

            message.Content = new StringContent($"{{ \"user_id\": {user.Id}, \"post\": {JsonConvert.SerializeObject(post)} }}");

            return message;
        }

        public HttpRequestMessage GetPost(string postId) {
            var message = new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{_host}/{postId}")
            };

            return message;
        }

        public HttpRequestMessage Modify(PostDTO post) {
            var message = new HttpRequestMessage {
                Method = HttpMethod.Put,
                RequestUri = new Uri($"{_host}")
            };

            message.Content = new StringContent(JsonConvert.SerializeObject(post));

            return message;
        } 
    }
}