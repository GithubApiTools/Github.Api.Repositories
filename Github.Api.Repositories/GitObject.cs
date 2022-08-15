using System.Text.Json.Serialization;

namespace Github.Api.Repositories
{
    /// <summary>
    /// The ultimate source for the network
    /// </summary>
    /// <seealso href="https://docs.github.com/en/rest/repos">Repositories</seealso>
    public class GitObject
    {
        /// <summary>
        /// Github API Url for this object
        /// </summary>
        [JsonPropertyName("url")]
        public Uri? Url { get; set; }
    }
}