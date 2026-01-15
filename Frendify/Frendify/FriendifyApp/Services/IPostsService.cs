using CircleApp.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp.Services
{
    public interface IPostsService
    {
        //Task<List<Post>> GetAllPostsAsync(int loggedInUserId);
        Task<List<Post>> GetAllFavoritedPostsAsync(int loggedInUserId);
        Task TogglePostFavoriteAsync(int postId, int userId);


    }
}
