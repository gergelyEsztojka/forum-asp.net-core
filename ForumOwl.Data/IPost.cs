﻿using ForumOwl.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ForumOwl.Data
{
    public interface IPost
    {
        IPost GetById(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetFilteredPosts(string searchQuery);
        IEnumerable<Post> GetPostsByForum(int id);

        Task Add(Post post);
        Task Delete(int id);
        Task EditPostContent(int id, string newContent);
    }
}
