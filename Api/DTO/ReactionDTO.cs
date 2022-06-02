using Newtonsoft.Json;


namespace Mattermost.Bot.Api.DTO
{
    public class ReactionDTO
    {
        [JsonProperty(PropertyName = "post_id")]
        public string PostId { get; set; }

        [JsonProperty(PropertyName = "user_id")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "emoji_name")]
        public string EmojiName { get; set; } 

        [JsonProperty(PropertyName = "create_at")]
        public long CreateAt { get; set; }
    }
}