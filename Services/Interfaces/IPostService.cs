using DAL.Dto.Request;
using DAL.Dto.Response;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IPostService
    {
        Task<OpenPostResponse> AddPost(AddPostRequest PostRequest,Guid CreatorId);
        Task<IEnumerable<PostResponse>> GetAll(GetPostsRequest postsRequest);
        Task<Post> GetPostById(Guid PostId);
        Task<OpenPostResponse> GetPostResponseById(Guid PostId);
        Task<OpenPostResponse> ChangePriceOnPost(ChangePriceOnPostRequest priceOnPostRequest, Guid id);
        Task<ExamplePostResponse> GetExamplePostResponse();
        Task DeletePost(Guid Id);
        Task<IEnumerable<PostResponse>> GetAllPostsByAppUserId(Guid Id);


    }
}
