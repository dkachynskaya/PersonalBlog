using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.BLL.DTOs
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Approved { get; set; }
        public User ApprovedBy { get; set; }
        public DateTimeOffset ApprovedWhen { get; set; }
    }
}
