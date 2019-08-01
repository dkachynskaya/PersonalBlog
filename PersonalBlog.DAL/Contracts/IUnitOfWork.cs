using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.DAL.Contracts
{
    interface IUnitOfWork: IDisposable
    {
        IArticleRepository ArticleRepository { get; }
        ICommentRepository CommentRepository { get; }
        ITagRepository TagRepository { get; }
        void Save();
    }
}
