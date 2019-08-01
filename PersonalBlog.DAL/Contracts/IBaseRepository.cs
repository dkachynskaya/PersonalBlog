using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PersonalBlog.DAL.Entities;

namespace PersonalBlog.DAL.Contracts
{
    public interface IBaseRepository<TKey, TObject> where TObject : BaseEntity<TKey>
    {
        Task<ICollection<TObject>> GetAllAsync();
        Task<TObject> AddAsync(TObject t);
        Task<TObject> UpdateAsync(TObject updated);
        Task<TObject> FindAsync(TKey id);
        Task<bool> DeleteAsync(TKey id);    
    }
}
