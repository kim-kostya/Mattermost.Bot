using Newtonsoft.Json;


namespace Mattermost.Bot.Api.DTO
{
    public class ListOfRequestDTO
    {
        [JsonProperty(PropertyName = "per_page")]
        public int PerPage { get; set; } = 60;
        
        [JsonProperty(PropertyName = "page")]
        public int Page { get; set; }
    }
}