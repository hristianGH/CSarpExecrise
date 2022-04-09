using SiteX.Data.Common.Repositories;
using SiteX.Data.Models.Blog;
using SiteX.Services.Data.BlogService.Interface;
using SiteX.Web.ViewModels.BlogViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Services.Data.BlogService
{
    public class PostService : IPostService
    {
        private readonly IDeletableEntityRepository<Post> postRepo;
        private readonly IDeletableEntityRepository<PostGenre> postGenreRepo;

        public PostService(
            IDeletableEntityRepository<Post> postRepo,
            IDeletableEntityRepository<PostGenre> postGenreRepo)
        {
            this.postRepo = postRepo;
            this.postGenreRepo = postGenreRepo;
        }

        public async Task CreatePostAsync(PostViewModel viewModel)
        {
            var pics = new List<PostImage>();
            foreach (var pic in viewModel.PostImages.Where(x => x != null))
            {
                pics.Add(new PostImage() { Path = pic });
            }


            var post = new Post()
            {
                Body = viewModel.Body,
                Title = viewModel.Title,
                PostImages = pics,
                
            };


            await this.postRepo.AddAsync(post);
            await this.postRepo.SaveChangesAsync();
            ;
            ;
            ;
            await this.CreatingPostGenre(viewModel.PostGenres, post.Id);

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

        public Post GetPost()
        {
            return postRepo.AllAsNoTracking().FirstOrDefault();
        }
    }
}
