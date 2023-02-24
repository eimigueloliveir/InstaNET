using InstaNET.Posts;
using InstaNET.Users;

namespace InstaNET
{
    public class InstagramClient
    {
        public UsersClient Users { get; } = new UsersClient();
        private PostsClient Posts { get; } = new PostsClient();
    }
}
