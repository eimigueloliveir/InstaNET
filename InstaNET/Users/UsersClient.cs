using System.Threading.Tasks;

namespace InstaNET.Users
{
    public class UsersClient
    {
        private readonly UsersController _controller = new UsersController();
        public async Task<InstagramUser> GetProfileAsync(string username)
        {
            return await _controller.GetInstagramUser(username);
        }
    }
}
