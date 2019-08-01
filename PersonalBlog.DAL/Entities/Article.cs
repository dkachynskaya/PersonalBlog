using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.DAL.Entities
{
    class Article: BaseEntity<int>
    {
        public string Title { get; set; }
        public string ShortMessage { get; set; }
        public string FullMessage { get; set; }
        public DateTimeOffset Date { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
