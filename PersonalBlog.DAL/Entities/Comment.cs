using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.DAL.Entities
{
    class Comment: BaseEntity<int>
    {
        public string Text { get; set; }
        public bool Approved { get; set; }
        public User ApprovedBy { get; set; }
        public DateTimeOffset ApprovedWhen { get; set; }


        public int UserId { get; set; }
        public User User { get; set; }

        public int ArticleId { get; set; }
        public Article Article { get; set; }
    }
}
