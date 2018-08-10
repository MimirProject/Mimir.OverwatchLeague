using Newtonsoft.Json;

namespace Mimir.OverwatchLeague.Models
{
    public partial class AccountResponse
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("accountType")]
        public string AccountType { get; set; }
    }
}