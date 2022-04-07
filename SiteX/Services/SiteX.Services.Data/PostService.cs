using SiteX.Data.Common.Repositories;
using SiteX.Data.Models.Blog;
using SiteX.Services.Data.Interface;
using SiteX.Web.ViewModels.BlogViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Services.Data
{
    public class PostService : IPostService
    {
        private readonly IRepository<Post> postRepo;
        private readonly IRepository<PostGenre> postGenreRepo;

        public PostService(IRepository<Post> postRepo,
            IRepository<PostGenre> postGenreRepo)
        {
            this.postRepo = postRepo;
            this.postGenreRepo = postGenreRepo;
        }

        public async Task CreatePostAsync(PostViewModel viewModel)
        {
            var post = new Post()
            {
                Body = viewModel.Body,
                Title = viewModel.Title
            };
           await postRepo.AddAsync(post);
            await postRepo.SaveChangesAsync();
            await CreatingPostGenre(viewModel.PostGenres, post.Id);
        }

        public async Task CreatingPostGenre(ICollection<int> genres, int post)
        {
            foreach (var item in genres)
            {
                var entity = new PostGenre();
                entity.PostId = post;
                entity.GenreId = item;

                await this.postGenreRepo.AddAsync(entity);
            }
            await this.postGenreRepo.SaveChangesAsync();
        }
    }
}
