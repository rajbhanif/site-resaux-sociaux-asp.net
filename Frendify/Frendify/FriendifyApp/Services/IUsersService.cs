using CircleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp.Services
{
    public interface IUsersService
    {
        Task<User> GetUser(int loggedInUserId);
        Task UploadUserProfilePicture(int loggedInUserId, string profilePictureUrl);
    }
}
