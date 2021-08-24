using EmreDemir.Business.Abstract;
using EmreDemir.Entities.Conrete;
using EmreDemir.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace EmreDemir.UI.Controllers
{
    public class PostController : Controller
    {
        private IPostService _service;
        private IWebHostEnvironment _host;
        public PostController(IPostService postService, IWebHostEnvironment webHost)
        {
            _service = postService;
            _host = webHost;
        }
        public IActionResult Index(int page = 1)
        {
            IPagedList<PostCard> mylist = _service.GetWithPage();


            mylist = mylist.Reverse().ToPagedList(page, 4);
            
            var model = new PostViewModel
            {
                pagePost = mylist,

            };
            return View(model);
        }

        public IActionResult DetailPost(int Id)
        {
            var detailPost = _service.Get(Id);

            var model = new PostViewModel
            {
                Post = detailPost
            };

            return View(model);
        }

        public IActionResult Contact()
        {
            return View();
        }

       

        [Authorize]
        public IActionResult Ekle()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult Ekle(PostCard Post)
        {
            

            _service.add(Post);

            return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult Sil(int Id)
        {
            PostCard post = _service.Get(Id);

            _service.delete(post);

            return RedirectToAction("Index");
        }
        [Authorize]
        public IActionResult Düzenle(int Id)
        {
            var model = new PostViewModel
            {
                Post = _service.Get(Id)
            };
            return View(model);
        }
        [Authorize]
        [HttpPost]
        public IActionResult Düzenle(PostCard Post)
        {
            
            _service.update(Post);
            return RedirectToAction("Index");
        }
    }
}
