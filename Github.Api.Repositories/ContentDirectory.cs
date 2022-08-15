using System.Text.Json.Serialization;

namespace Github.Api.Repositories
{
    /// <summary>
    /// The contents of a file or directory in a repository
    /// </summary>
    /// 
    /// <seealso href="https://docs.github.com/en/rest/repos/contents">Github Docs : Contents</seealso>
    public class ContentDirectory : GitObject
    {
        /// <summary>
        /// Github API Url
        /// </summary>
        private static readonly string Api = "https://api.github.com";
        /// <summary>
        /// Name of the object
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        /// <summary>
        /// Path to the object
        /// </summary>
        [JsonPropertyName("path")]
        public string? Path { get; set; }
        /// <summary>
        /// The file's SHA-1 hash
        /// </summary>
        [JsonPropertyName("sha")]
        public string? Sha { get; set; }
        /// <summary>
        /// File size in bytes
        /// </summary>
        [JsonPropertyName("size")]
        public int Size { get; set; }
         /// <summary>
        /// A Url to view this object in a browser
        /// </summary>
        [JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }
        /// <summary>
        /// Github API Url for this objects blob
        /// </summary>
        [JsonPropertyName("git_url")]
        public string? GitUrl { get; set; }
        /// <summary>
        /// The raw file download URl
        /// </summary>
        [JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }
        /// <summary>
        /// file or dir
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        /// <summary>
        /// Collection of links
        /// </summary>
        [JsonPropertyName("_links")]
        public Links? Links { get; set; }
        /// <summary>
        /// A method to return the default header
        /// </summary>
        /// <returns>The recommended header</returns>
        public static string GetHeader()
        {
            return "application/vnd.github+json";
        }
        /// <summary>
        /// A method to return the API Url
        /// </summary>
        /// <returns></returns>
        public static Uri GetApiUrl()
        {
            return new Uri(Api);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <param name="Name">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        public static Uri GetEndpointUrl(string Owner, string Name)
        {
            return new Uri(Api + "/repos/" + Owner + "/" + Name + "/contents");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <param name="Name">The name of the repository. The name is not case sensitive.</param>
        /// <param name="Path">Path parameter</param>
        /// <returns></returns>
        public static Uri GetEndpointUrl(string Owner, string Name, string Path)
        {
            return new Uri(Api + "/repos/" + Owner + "/" + Name + "/contents/" + Path);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <param name="Name">The name of the repository. The name is not case sensitive.</param>
        /// <param name="Path">Path parameter</param>
        /// <param name="Ref">The name of the commit/branch/tag. Default: the repository’s default branch (usually master)</param>
        /// <returns></returns>
        public static Uri GetEndpointUrl(string Owner, string Name, string Path, string Ref)
        {
            return new Uri(Api + "/repos/" + Owner + "/" + Name + "/contents/" + Path + "?ref=" + Ref);
        }
    }
}