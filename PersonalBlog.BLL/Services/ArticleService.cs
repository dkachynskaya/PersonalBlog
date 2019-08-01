using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalBlog.BLL.Contracts;
using PersonalBlog.DAL.Contracts;
using PersonalBlog.BLL.DTOs;
using PersonalBlog.DAL.Entities;
using AutoMapper;

namespace PersonalBlog.BLL.Services
{
    public class ArticleService: IArticleService
    {
        private IUnitOfWork _uow;

        public ArticleService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task CreateArticle(ArticleDTO articleDto)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ArticleDTO, Article>()).CreateMapper();
            var article = mapper.Map<ArticleDTO, Article>(articleDto);

            await _uow.ArticleRepository.AddAsync(article);
        }
    }
}
