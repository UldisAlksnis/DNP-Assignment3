using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Assignment1.Models.Authorization
{
    public class User
    {
        [NotNull]
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
        [NotNull]
        [JsonPropertyName("domain")]
        public string Domain { get; set; }
        [NotNull]
        [JsonPropertyName("city")]
        public string City { get; set; }
        [NotNull]
        [JsonPropertyName("birthYear")]
        public int BirthYear { get; set; }
        [NotNull]
        [JsonPropertyName("role")]
        public string Role { get; set; }
        [NotNull]
        [JsonPropertyName("securityLevel")]
        public int SecurityLevel { get; set; }
        [NotNull]
        [JsonPropertyName("password")]

        public string Password { get; set; }

    }
}
