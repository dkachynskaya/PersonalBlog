using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalBlog.DAL.Entities;
using PersonalBlog.DAL.Contracts;

namespace PersonalBlog.DAL.Repositories
{
    class ArticleRepository: BaseRepository<int, Article>, IArticleRepository
    {
        public ArticleRepository(BlogContext context)
            : base(context)
        {

        }
    }
}
