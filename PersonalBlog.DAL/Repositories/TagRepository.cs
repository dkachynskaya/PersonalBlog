using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalBlog.DAL.Entities;
using PersonalBlog.DAL.Contracts;

namespace PersonalBlog.DAL.Repositories
{
    public class TagRepository: BaseRepository<int, Tag>, ITagRepository
    {
        public TagRepository(BlogContext context)
            : base(context)
        {
           
        }
    }
}
