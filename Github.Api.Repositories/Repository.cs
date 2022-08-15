using System.Text.Json.Serialization;

namespace Github.Api.Repositories
{
    /// <summary>
    /// The ultimate source for the network
    /// </summary>
    /// 
    /// <seealso href="https://docs.github.com/en/rest/repos/repos">Github Docs : Repositories</seealso>
    public class Repository : GitObject
    {
        /// <summary>
        /// Github API Url
        /// </summary>
        private static readonly string Api = "https://api.github.com";
        /// <summary>
        /// Github Id
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
        /// <summary>
        /// Id of a Node (Node is a generic term for an object) used in GraphQL
        /// </summary>
        [JsonPropertyName("node_id")]
        public string? NodeId { get; set; }
        /// <summary>
        /// The name of the repository.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        /// <summary>
        /// A short description of the repository
        /// </summary>
        [JsonPropertyName("full_name")]
        public string? FullName { get; set; }
        /// <summary>
        /// Either true to make the repository private or false to make it public
        /// </summary>
        [JsonPropertyName("private")]
        public bool Private { get; set; }
        /// <summary>
        /// Owner object
        /// </summary>
        [JsonPropertyName("owner")]
        public Owner? Owner { get; set; }
        /// <summary>
        /// A Url to view this object in a browser
        /// </summary>
        [JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }
        /// <summary>
        /// A short description of the repository
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        /// <summary>
        /// True if this repository is forked
        /// </summary>
        [JsonPropertyName("fork")]
        public bool Fork { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("forks_url")]
        public string? ForksUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("keys_url")]
        public string? KeysUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("collaborators_url")]
        public string? CollaboratorsUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("teams_url")]
        public string? TeamsUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("hooks_url")]
        public string? HooksUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("issue_events_url")]
        public string? IssueEventsUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("events_url")]
        public string? EventsUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("assignees_url")]
        public string? AssigneesUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("branches_url")]
        public string? BranchesUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("tags_url")]
        public string? TagsUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("blobs_url")]
        public string? BlobsUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("git_tags_url")]
        public string? GitTagsUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("git_refs_url")]
        public string? GitRefsUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("trees_url")]
        public string? TreesUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("statuses_url")]
        public string? StatusesUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("languages_url")]
        public string? LanguagesUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("stargazers_url")]
        public string? StargazersUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("contributors_url")]
        public string? ContributorsUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("subscribers_url")]
        public string? SubscribersUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("subscription_url")]
        public string? SubscriptionUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("commits_url")]
        public string? CommitsUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("git_commits_url")]
        public string? GitCommitsUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("comments_url")]
        public string? CommentsUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("issue_comment_url")]
        public string? IssueCommentUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("contents_url")]
        public string? ContentsUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("compare_url")]
        public string? CompareUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("merges_url")]
        public string? MergesUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("archive_url")]
        public string? ArchiveUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("downloads_url")]
        public string? DownloadsUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("issues_url")]
        public string? IssuesUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("pulls_url")]
        public string? PullsUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("milestones_url")]
        public string? MilestonesUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("notifications_url")]
        public string? NotificationsUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("labels_url")]
        public string? LabelsUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("releases_url")]
        public string? ReleasesUrl { get; set; }
        /// <summary>
        /// Github API Endpoint Url
        /// </summary>
        [JsonPropertyName("deployments_url")]
        public string? DeploymentsUrl { get; set; }
        /// <summary>
        /// Repository Creation Date
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// Repository Update Date
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
        /// <summary>
        /// Most recent push
        /// </summary>
        [JsonPropertyName("pushed_at")]
        public DateTime PushedAt { get; set; }
        /// <summary>
        /// Git Clone Url
        /// </summary>
        [JsonPropertyName("git_url")]
        public string? GitUrl { get; set; }
        /// <summary>
        /// Ssh Clone Url
        /// </summary>
        [JsonPropertyName("ssh_url")]
        public string? SshUrl { get; set; }
        /// <summary>
        /// Http Clone Url
        /// </summary>
        [JsonPropertyName("clone_url")]
        public string? CloneUrl { get; set; }
        /// <summary>
        /// Svn Clone Url
        /// </summary>
        [JsonPropertyName("svn_url")]
        public string? SvnUrl { get; set; }
        /// <summary>
        /// A URL with more information about the repository
        /// </summary>
        [JsonPropertyName("homepage")]
        public string? Homepage { get; set; }
        /// <summary>
        /// Size in bytes
        /// </summary>
        [JsonPropertyName("size")]
        public int Size { get; set; }
        /// <summary>
        /// Count of Stargazers
        /// </summary>
        [JsonPropertyName("stargazers_count")]
        public int StargazersCount { get; set; }
        /// <summary>
        /// Count of Watchers
        /// </summary>
        [JsonPropertyName("watchers_count")]
        public int WatchersCount { get; set; }
        /// <summary>
        /// Repository Language
        /// </summary>
        [JsonPropertyName("language")]
        public string? Language { get; set; }
        /// <summary>
        /// Either true to enable issues for this repository or false to disable them
        /// </summary>
        [JsonPropertyName("has_issues")]
        public bool HasIssues { get; set; }
        /// <summary>
        /// Either true to enable projects for this repository or false to disable them
        /// </summary>
        [JsonPropertyName("has_projects")]
        public bool HasProjects { get; set; }
        /// <summary>
        /// True or False if downloads are available
        /// </summary>
        [JsonPropertyName("has_downloads")]
        public bool HasDownloads { get; set; }
        /// <summary>
        /// Either true to enable the wiki for this repository or false to disable it.
        /// </summary>
        [JsonPropertyName("has_wiki")]
        public bool HasWiki { get; set; }
        /// <summary>
        /// Either true to enable the pages for this repository or false to disable it.
        /// </summary>
        [JsonPropertyName("has_pages")]
        public bool HasPages { get; set; }
        /// <summary>
        /// Count of Forks
        /// </summary>
        [JsonPropertyName("forks_count")]
        public int ForksCount { get; set; }
        /// <summary>
        /// Mirror Url
        /// </summary>
        [JsonPropertyName("mirror_url")]
        public string? MirrorUrl { get; set; }
        /// <summary>
        /// true to archive this repository. Note: You cannot unarchive repositories through the API
        /// </summary>
        [JsonPropertyName("archived")]
        public bool Archived { get; set; }
        /// <summary>
        /// True or False
        /// </summary>
        [JsonPropertyName("disabled")]
        public bool Disabled { get; set; }
        /// <summary>
        /// Count of open issues
        /// </summary>
        [JsonPropertyName("open_issues_count")]
        public int OpenIssuesCount { get; set; }
        /// <summary>
        /// License Object
        /// </summary>
        [JsonPropertyName("license")]
        public object? License { get; set; }
        /// <summary>
        /// Either true to allow private forks, or false to prevent private forks
        /// </summary>
        [JsonPropertyName("allow_forking")]
        public bool AllowForking { get; set; }
        /// <summary>
        /// Either true to make this repo available as a template repository or false to prevent it
        /// </summary>
        [JsonPropertyName("is_template")]
        public bool IsTemplate { get; set; }
        /// <summary>
        /// True or False for signoff
        /// </summary>
        [JsonPropertyName("web_commit_signoff_required")]
        public bool WebCommitSignoffRequired { get; set; }
        /// <summary>
        /// Topic List
        /// </summary>
        [JsonPropertyName("topics")]
        public List<object>? Topics { get; set; }
        /// <summary>
        /// Can be public or private
        /// </summary>
        [JsonPropertyName("visibility")]
        public string? Visibility { get; set; }
        /// <summary>
        /// Number of forks
        /// </summary>
        [JsonPropertyName("forks")]
        public int Forks { get; set; }
        /// <summary>
        /// Count of Open issues
        /// </summary>
        [JsonPropertyName("open_issues")]
        public int OpenIssues { get; set; }
        /// <summary>
        /// Number of watchers
        /// </summary>
        [JsonPropertyName("watchers")]
        public int Watchers { get; set; }
        /// <summary>
        /// Default repository branch
        /// </summary>
        [JsonPropertyName("default_branch")]
        public string? DefaultBranch { get; set; }
        /// <summary>
        /// Permissions object
        /// </summary>
        [JsonPropertyName("permissions")]
        public Permissions? Permissions { get; set; }
        /// <summary>
        /// Default ctor with required properties
        /// </summary>
        /// <param name="name"></param>
        public Repository(string name)
        {
            Name = name;
        }
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
        /// <returns></returns>
        public static Uri PostEndpoint()
        {
            return new Uri(Api + "users/repos" );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <param name="Repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        public static Uri GetEndpoint(string Owner, string Repo)
        {
            return new Uri(Api + "/repos/" + Owner + "/" + Repo);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Org">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <returns></returns>
        public static Uri PostOrgEndpoint(string Org)
        {
            return new Uri(Api + "/orgs/" + Org + "/repos");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Org">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <returns></returns>
        public static Uri GetOrgEndpoint(string Org)
        {
            return new Uri(Api + "/orgs/" + Org + "/repos");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Org">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <param name="PerPage">The number of results per page (max 100).</param>
        /// <param name="Page">Page number of the results to fetch</param>
        /// <returns></returns>
        public static Uri GetOrgEndpoint(string Org, int PerPage, int Page)
        {
            return new Uri(Api + "/orgs/" + Org + "/repos?per_page=" + PerPage + "&page=" + Page);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Org">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <param name="PerPage">The number of results per page (max 100).</param>
        /// <param name="Page">Page number of the results to fetch</param>
        /// <param name="Type">Specifies the types of repositories you want returned.</param>
        /// <param name="Direction">The order to sort by. Default: asc</param>
        /// <returns></returns>
        public static Uri GetOrgEndpoint(string Org, int PerPage, int Page, string Type, string Direction)
        {
            return new Uri(Api + "/orgs/" + Org + "/repos?per_page=" + PerPage + "&page=" + Page + "&type=" + Type + "&direction=" + Direction);
        }
    }
    /// <summary>
    /// Owner object
    /// </summary>
    public class Owner : GitObject
    {
        /// <summary>
        /// Username/Orgname
        /// </summary>
        [JsonPropertyName("login")]
        public string? Login { get; set; }
        /// <summary>
        /// Github Id
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
        /// <summary>
        /// Id of a Node (Node is a generic term for an object) used in GraphQL
        /// </summary>
        [JsonPropertyName("node_id")]
        public string? NodeId { get; set; }
        /// <summary>
        /// Url to Avatar image
        /// </summary>
        [JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }
        /// <summary>
        /// Url to Gravatar Id
        /// </summary>
        [JsonPropertyName("gravatar_id")]
        public string? GravatarId { get; set; }
        /// <summary>
        /// A Url to view this object in a browser
        /// </summary>
        [JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }
        /// <summary>
        /// Github API Url for followers endpoint
        /// </summary>
        [JsonPropertyName("followers_url")]
        public string? FollowersUrl { get; set; }
        /// <summary>
        /// Github API Url for following endpoint
        /// </summary>
        [JsonPropertyName("following_url")]
        public string? FollowingUrl { get; set; }
        /// <summary>
        /// Github API Url for Gists endpoint
        /// </summary>
        [JsonPropertyName("gists_url")]
        public string? GistsUrl { get; set; }
        /// <summary>
        /// Github API Url for Starred endpoint
        /// </summary>
        [JsonPropertyName("starred_url")]
        public string? StarredUrl { get; set; }
        /// <summary>
        /// Github API Url for Subscriptions endpoint
        /// </summary>
        [JsonPropertyName("subscriptions_url")]
        public string? SubscriptionsUrl { get; set; }
        /// <summary>
        /// Github API Url for Organizations endpoint
        /// </summary>
        [JsonPropertyName("organizations_url")]
        public string? OrganizationsUrl { get; set; }
        /// <summary>
        /// Github API Url for user's repos endpoint
        /// </summary>
        [JsonPropertyName("repos_url")]
        public string? ReposUrl { get; set; }
        /// <summary>
        /// Github API Url for Events endpoint
        /// </summary>
        [JsonPropertyName("events_url")]
        public string? EventsUrl { get; set; }
        /// <summary>
        /// Github API Url for received events endpoint
        /// </summary>
        [JsonPropertyName("received_events_url")]
        public string? ReceivedEventsUrl { get; set; }
        /// <summary>
        /// User/Organization
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        /// <summary>
        /// Enterprise SiteAdmin
        /// </summary>
        [JsonPropertyName("site_admin")]
        public bool SiteAdmin { get; set; }
    }
    /// <summary>
    /// Permissions object
    /// </summary>
    public class Permissions
    {
        /// <summary>
        /// Are you an admin
        /// </summary>
        [JsonPropertyName("admin")]
        public bool Admin { get; set; }
        /// <summary>
        /// Are you a maintainer
        /// </summary>
        [JsonPropertyName("maintain")]
        public bool Maintain { get; set; }
        /// <summary>
        /// Can you push
        /// </summary>
        [JsonPropertyName("push")]
        public bool Push { get; set; }
        /// <summary>
        /// Can you triage
        /// </summary>
        [JsonPropertyName("triage")]
        public bool Triage { get; set; }
        /// <summary>
        /// Can you pull
        /// </summary>
        [JsonPropertyName("pull")]
        public bool Pull { get; set; }
    }
}