

using Newtonsoft.Json;

namespace InstaNET.Users
{
    public class InstagramUser
    {
        public ulong Id { get => Graphql.User.Id; }
        public string Username { get => Graphql.User.Username; }
        public string FullName { get => Graphql.User.FullName; }
        public string ProfilePictureUrl { get => Graphql.User.ProfilePictureUrl; }
        public string ProfilePictureUrlHd { get => Graphql.User.ProfilePictureUrlHd; }
        public string Biography { get => Graphql.User.Biography; }
        public int FollowersCount { get => Graphql.User.Followed.Count; }
        public int FollowingCount { get => Graphql.User.Follow.Count; }
        public int PostsCount { get => Graphql.User.Midias.Count; }
        public bool IsPrivate { get => Graphql.User.IsPrivate; }
        public bool IsVerified { get => Graphql.User.IsVerified; }
        [JsonProperty("graphql")]
        internal Graphql Graphql { get; set; }

    }
    internal class Graphql
    {
        [JsonProperty("user")]
        internal User User { get; set; }
    }
    internal class User
    {
        [JsonProperty("id")]
        internal ulong Id { get; set; }
        [JsonProperty("username")]
        internal string Username { get; set; }
        [JsonProperty("full_name")]
        internal string FullName { get; set; }
        [JsonProperty("profile_pic_url")]
        internal string ProfilePictureUrl { get; set; }
        [JsonProperty("profile_pic_url_hd")]
        internal string ProfilePictureUrlHd { get; set; }
        [JsonProperty("biography")]
        internal string Biography { get; set; }
        [JsonProperty("is_private")]
        internal bool IsPrivate { get; set; }
        [JsonProperty("is_verified")]
        internal bool IsVerified { get; set; }
        [JsonProperty("edge_followed_by")]
        internal EdgeFollowedBy Followed { get; set; }
        [JsonProperty("edge_follow")]
        internal EdgeFollow Follow { get; set; }
        [JsonProperty("edge_owner_to_timeline_media")]
        internal EdgeOwnerToTimelineMedia Midias { get; set; }
    }
    internal class EdgeFollowedBy
    {
        [JsonProperty("count")]
        internal int Count { get; set; }
    }
    internal class EdgeFollow
    {
        [JsonProperty("count")]
        internal int Count { get; set; }
    }
    internal class EdgeOwnerToTimelineMedia
    {
        [JsonProperty("count")]
        internal int Count { get; set; }
    }
}
