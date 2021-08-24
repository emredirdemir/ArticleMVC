using EmreDemir.Entities.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace EmreDemir.UI.Models
{
    public class CategoryViewModel
    {
        public IEnumerable<string> CategoryName { get; set; }
        public IPagedList<PostCard> pagePost { get; set; }
        public string CategoryNM { get; set; }
        public int page { get; set; }
    }
}
