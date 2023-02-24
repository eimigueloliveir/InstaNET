using InstaNET;
using InstaNET.Users;



InstagramClient client = new();
InstagramUser user = await client.Users.GetProfileAsync("eimigueloliveir");

string username = user.Username;
string bio = user.Biography;
string profilePicture = user.ProfilePictureUrl;
string profilePicturehd = user.ProfilePictureUrlHd;
string fullName = user.FullName;
ulong id = user.Id;