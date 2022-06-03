using Newtonsoft.Json;

namespace Mattermost.Bot.Api.DTO
{
    public class ChannelDTO
    {
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }

        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        
        [JsonProperty(PropertyName = "header")]
        public string? Header { get; set; }
        
        [JsonProperty(PropertyName = "purpose")]
        public string? Purpose { get; set; }
        
        [JsonProperty(PropertyName = "team_id")]
        public string? TeamId { get; set; }

        [JsonProperty(PropertyName = "creator_id")]
        public string? CreatorId { get; set; }
    }
}