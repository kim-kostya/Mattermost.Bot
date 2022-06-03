using System.Text;
using System.Net.Http;
using System.Threading;
using System.Net.WebSockets;
using Mattermost.Bot.Exceptions;
using Newtonsoft.Json;
using Mattermost.Bot.Api.DTO;

namespace Mattermost.Bot {

    public class MattermostBot {
        public string Host { get; }
        public string Token { get; }

        private int _reconnectAttempts = 0;
        
        private bool _isAlive;
        public bool IsAlive { get => _isAlive; }

        private HttpClient _client;

        public MattermostBot(string host, string token) {
            Host = host;
            Token = token;

            _client = new HttpClient();
        }

        public void Run() {
            if (IsAlive) {
                throw new AlreadyRunningException();
            }

            new Thread(new ThreadStart( async () => {            
                using (var ws = new ClientWebSocket())
                {
                    _isAlive = true;
                    await Connect(ws);
                    
                    while (true) {
                        if (ws.State == WebSocketState.Aborted) {
                            await Connect(ws);
                        } else if (ws.State == WebSocketState.Open) {
                            await Loop(ws);
                        } else {
                            break;
                        }
                    }

                    _isAlive = false;
                }
            }));
        }

        private async Task Connect(ClientWebSocket ws) {
            await ws.ConnectAsync(new Uri($"ws://{Host}/api/v4/websocket"), CancellationToken.None);

            var req = JsonConvert.SerializeObject(new {
                seq = 1,
                action = "authentication_challenge",
                data = new {
                    token = Token
                }
            });

            var buffer = new ArraySegment<byte>(
                Encoding.UTF8.GetBytes(req)
            );
            
            await ws.SendAsync(buffer, WebSocketMessageType.Text, true, CancellationToken.None);
        }

        private async Task Loop(ClientWebSocket ws) {
            var buffer = new ArraySegment<byte>();
            await ws.ReceiveAsync(buffer, CancellationToken.None);
            var messageRaw = Encoding.UTF8.GetString(buffer);

            var response = JsonConvert.DeserializeObject<dynamic>(messageRaw);
        }
    }
}