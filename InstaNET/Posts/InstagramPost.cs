using InstaNET.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace InstaNET.Posts
{
    public class InstagramPost
    {
        public ulong Id { get; }
        public string CaptionText { get; }
        public DateTime CreatedAt { get; }
        public List<InstagramUser> UsersTagged { get; }
        public InstagramUser Owner { get; }
    }
}
