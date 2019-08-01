using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.BLL.DTOs
{
    public class ArticleDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortMessage { get; set; }
        public string FullMessage { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}
