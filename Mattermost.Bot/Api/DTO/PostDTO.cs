using Newtonsoft.Json;

namespace Mattermost.Bot.Api.DTO {
    public class PostDTO {
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }

        [JsonProperty(PropertyName = "author_id")]
        public string? AuthorId { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string? Message { get; set; }

        [JsonProperty(PropertyName = "root_id")]
        public string? RootId { get; set; }

        [JsonProperty(PropertyName = "file_ids")]
        public string[]? FileIds { get; set; }
    }
}