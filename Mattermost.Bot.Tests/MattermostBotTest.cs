using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Mattermost.Bot.Tests
{
    public class MattermostBotTest
    {
        [Fact]
        public void CreateBot() {
            Console.WriteLine("Hello World");
            var result = JsonConvert.DeserializeObject<dynamic>("{\n\"user_id\": \"string\",\n\"post_id\": \"string\",\n\"emoji_name\": \"string\",\n\"create_at\": 0\n}");
            Console.WriteLine(result.user_id);
        }
    }
}