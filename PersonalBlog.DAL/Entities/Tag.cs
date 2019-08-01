using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.DAL.Entities
{
    class Tag: BaseEntity<int>
    {
        public string Name { get; set; }
    }
}
