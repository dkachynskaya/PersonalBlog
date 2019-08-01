using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalBlog.DAL.Entities;
using PersonalBlog.DAL.Contracts;

namespace PersonalBlog.DAL.Repositories
{
    class CommentRepository: BaseRepository<int, Comment>, ICommentRepository
    {
        public CommentRepository(BlogContext context)
            : base(context)
        {

        }
    }
}
