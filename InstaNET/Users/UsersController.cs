using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace InstaNET.Users
{
    public class UsersController
    {
        private readonly HttpClient Client = new HttpClient();
        public async Task<InstagramUser> GetInstagramUser(string username)
        {
            string url = $"https://www.instagram.com/{username}/?__a=1&__d=dis";
            string response = await Client.GetStringAsync(url);
            return JsonConvert.DeserializeObject<InstagramUser>(response)!;
        }
    }
}
