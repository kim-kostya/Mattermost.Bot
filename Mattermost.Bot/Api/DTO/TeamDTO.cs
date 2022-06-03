using Newtonsoft.Json;

namespace Mattermost.Bot.Api.DTO
{
    public class TeamDTO
    {
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }

        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string? Email { get; set; }

        [JsonProperty(PropertyName = "allowed_domains")]
        public string? AllowedDomains { get; set; }

        [JsonProperty(PropertyName = "invite_id")]
        public string? InviteId { get; set; }

        [JsonProperty(PropertyName = "allow_open_invite")]
        public bool AllowOpenInvite { get; set; }
        
        [JsonProperty(PropertyName = "policy_id")]
        public string? PolicyId { get; set; }  
    }
}