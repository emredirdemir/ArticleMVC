using EmreDemir.Entities.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace EmreDemir.Business.Abstract
{
    public interface IPostService
    {
        void add(PostCard entity);
        void update(PostCard entity);
        void delete(PostCard entity);
        List<PostCard> GetAll(int postId);
        IPagedList<PostCard> GetWithPage();
        PostCard Get(int postId);
        List<PostCard> CategoryOfPost(string CategoryName);

    }
}
