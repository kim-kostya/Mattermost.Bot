using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mattermost.Bot.Api
{
    public class FilesApiRequest
    {
        private string _host;

        public FilesApiRequest(string host) {
            _host = host;
        }

        public HttpRequestMessage UploadFile(string filename, Stream stream, string channelId) {
            var message = new HttpRequestMessage {
                Method = HttpMethod.Post,
                RequestUri = new Uri(_host)
            };

            var content = new MultipartFormDataContent();
            content.Add(new StreamContent(stream), "files", filename);
            content.Add(new StringContent(channelId), "channel_id");

            message.Content = content;

            return message;
        }

        public HttpRequestMessage GetFile(string fileId) {
            var message = new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri(_host)
            };

            return message;
        }

        public HttpRequestMessage GetFileLink(string fileId) {
            var message = new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{_host}/link")
            };

            return message;
        }
    }
}