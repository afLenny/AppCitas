using AppCitas.DTOs;
using AppCitas.Entities;
using AppCitas.Helpers;

namespace AppCitas.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
        Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);
        Task<AppUser> GetUserWithLikes(int userId);
    }
}
