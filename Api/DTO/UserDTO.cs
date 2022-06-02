using Newtonsoft.Json;

namespace Mattermost.Bot.Api.DTO
{
    public class UserDTO
    {
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        
        [JsonProperty(PropertyName = "email")]
        public string? Email { get; set; }
        
        [JsonProperty(PropertyName = "first_name")]
        public string? FirstName { get; set; }
        
        [JsonProperty(PropertyName = "last_name")]
        public string? LastName { get; set; }
        
        [JsonProperty(PropertyName = "nickname")]
        public string? Nickname { get; set; }
        
        [JsonProperty(PropertyName = "locale")]
        public string? Locale { get; set; }

        [JsonProperty(PropertyName = "roles")]
        public string[]? Roles { get; set; }
    }
}