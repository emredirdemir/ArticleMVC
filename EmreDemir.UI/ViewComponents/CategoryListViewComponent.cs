using EmreDemir.Business.Abstract;
using EmreDemir.Entities.Conrete;
using EmreDemir.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmreDemir.UI.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        private IPostService _postService;
        public CategoryListViewComponent(IPostService postService)
        {
            _postService = postService;
        }

        public ViewViewComponentResult Invoke()
        {
            List<string> list = _postService.GetAll(-123).Select(p => p.PostCategory).ToList();
            var model = new CategoryViewModel
            {
                CategoryName =  list.Distinct().Reverse()
            };

            return View(model);
        }
    }
}
