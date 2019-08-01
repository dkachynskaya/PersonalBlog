using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalBlog.BLL.DTOs;

namespace PersonalBlog.BLL.Contracts
{
    public interface IArticleService
    {
        Task CreateArticle(ArticleDTO articleDto);
    }
}
