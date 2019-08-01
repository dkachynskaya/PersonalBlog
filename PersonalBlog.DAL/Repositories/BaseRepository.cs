using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PersonalBlog.DAL.Contracts;
using PersonalBlog.DAL.Entities;

namespace PersonalBlog.DAL.Repositories
{
    public abstract class BaseRepository<TKey, TObject>: IBaseRepository<TKey, TObject> where TObject: BaseEntity<TKey>
    {
        protected BlogContext _context;

        protected BaseRepository(BlogContext context)
        {
            _context = context;
        }

        protected DbSet<TObject> DbSet
        {
            get { return _context.Set<TObject>(); }
        }

        public virtual async Task<ICollection<TObject>> GetAllAsync()
        {
            return await DbSet.ToListAsync();
        }

        public virtual Task<TObject> AddAsync(TObject t)
        {
            DbSet.Add(t);
           // await _context.SaveChangesAsync();
            return Task.FromResult(t);
        }

        public virtual async Task<TObject> FindAsync(TKey id)
        {
            return await DbSet.SingleOrDefaultAsync(id);
        }

        public virtual async Task<ICollection<TObject>> FindAllAsync(Expression<Func<TObject, bool>> match)
        {
            return await DbSet.Where(match).ToListAsync();
        }

        public virtual async Task<TObject> UpdateAsync(TObject updated)
        {
            if (updated == null)
                return null;

            TObject existing = await DbSet.FindAsync(GetPrimaryKey(updated));
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(updated);
                //await _context.SaveChangesAsync();
            }
            else
            {
                await AddAsync(updated);
            }
            return existing;
        }

        public virtual Task<bool> DeleteAsync(TKey id)
        {
            DbSet.Remove(id);
            return Task.FromResult(1); //await _context.SaveChangesAsync();
        }

        public virtual async Task<int> CountAsync()
        {
            return await DbSet.CountAsync();
        }

        protected abstract object[] GetPrimaryKey(TObject entity);
    }
}
