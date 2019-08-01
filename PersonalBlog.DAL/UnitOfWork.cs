using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalBlog.DAL.Contracts;
using PersonalBlog.DAL.Repositories;


namespace PersonalBlog.DAL
{
    public class UnitOfWork: IUnitOfWork
    {
        private BlogContext _context;
        private IArticleRepository articleRepository;
        private ICommentRepository commentRepository;
        private ITagRepository tagRepository;

        public UnitOfWork(string connectionString)
        {
            _context = new BlogContext(connectionString);
        }

        public IArticleRepository ArticleRepository
        {
            get
            {
                if (articleRepository == null)
                    articleRepository = new ArticleRepository(_context);
                return articleRepository;
            }
        }

        public ICommentRepository CommentRepository
        {
            get
            {
                if (commentRepository == null)
                    commentRepository = new CommentRepository(_context);
                return commentRepository;
            }
        }

        public ITagRepository TagRepository
        {
            get
            {
                if (tagRepository == null)
                    tagRepository = new TagRepository(_context);
                return tagRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
