using EmreDemir.Business.Abstract;
using EmreDemir.DataAccess.Abstract;
using EmreDemir.Entities.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace EmreDemir.Business.Concrete
{
    public class PostManager : IPostService
    {
        private IPostDal _postDal;
        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }
        public void add(PostCard entity)
        {
            _postDal.add(entity);
        }

        public List<PostCard> CategoryOfPost(string CategoryName)
        {
            return _postDal.GetCategoryName(p => p.PostCategory == CategoryName).ToList();
        }

        public void delete(PostCard entity)
        {
            _postDal.delete(entity);
        }

        public PostCard Get(int postId)
        {
            return _postDal.Get(p => p.Id == postId);
        }

        public List<PostCard> GetAll(int postId = -123)
        {
            return postId == -123 ? _postDal.GetAll() : _postDal.GetAll(p => p.Id == postId);
        }

        public IPagedList<PostCard> GetWithPage()
        {
            return _postDal.GetWithPage();
        }

        public void update(PostCard entity)
        {
            _postDal.update(entity);
        }
    }
}
