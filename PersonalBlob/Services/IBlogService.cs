using PersonalBlob.Models;
using System.Collections.Generic;

namespace PersonalBlob.Services
{
    public interface IBlogService
    {
        List<BlogPost> GetLatestPosts();
        List<BlogPost> GetOlderPosts(int olderBlogPost);

        string GetPostText(string link);

    }
}
