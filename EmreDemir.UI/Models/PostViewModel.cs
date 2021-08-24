using EmreDemir.Entities.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace EmreDemir.UI.Models
{
    public class PostViewModel
    {
        public List<PostCard> posts { get; set; }
        public IPagedList<PostCard> pagePost { get; set; }
        public PostCard Post { get; set; }
        public int PageCount { get; set; }
    }
}
