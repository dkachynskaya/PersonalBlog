using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalBlog.DAL.Entities;

namespace PersonalBlog.DAL.Contracts
{
    public interface ICommentRepository: IBaseRepository<int, Comment>
    {
    }
}
