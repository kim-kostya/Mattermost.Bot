using Newtonsoft.Json;

namespace Mattermost.Bot.Api.DTO
{
    public class ListOfChannelsRequestDTO
    {
        [JsonProperty(PropertyName = "associated_to_group")]
        public string AssociatedToGroup { get; set; } = "";

        [JsonProperty(PropertyName = "per_page")]
        public int PerPage { get; set; } = 60;

        [JsonProperty(PropertyName = "page")]
        public int Page { get; set; }

        [JsonProperty(PropertyName = "exclude_default_channels")]
        public bool ExcludeDefaultChannels { get; set; } = false;
        
        [JsonProperty(PropertyName = "include_deleted")]
        public bool IncludeDeleted { get; set; } = false;
    }
}