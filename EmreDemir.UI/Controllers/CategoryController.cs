using EmreDemir.Business.Abstract;
using EmreDemir.Entities.Conrete;
using EmreDemir.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace EmreDemir.UI.Controllers
{
    public class CategoryController : Controller
    {
        public IPostService _postService;
        public CategoryController(IPostService postService)
        {
            _postService = postService;
        }
        public IActionResult IndexCategory()
        {
            List<string> list = _postService.GetAll(-123).Select(p => p.PostCategory).ToList();


            var model = new CategoryViewModel
            {
                CategoryName = list.Distinct()
            };

            return View(model);
        }

        public IActionResult GetByPost(string CategoryName)
        {
            
           
            
            List<PostCard> ListPosts = _postService.CategoryOfPost(CategoryName);

            var model = new PostViewModel
            {
                posts = ListPosts,

            };
            return View(model);
        }
   
    }
}


