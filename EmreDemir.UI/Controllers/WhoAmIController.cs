using EmreDemir.Business.Abstract;
using EmreDemir.DataAccess.Abstract;
using EmreDemir.Entities.Concrete;
using EmreDemir.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EmreDemir.UI.Controllers
{
    public class WhoAmIController : Controller
    {
        private IWhoService _whoService;
        private IWebHostEnvironment _hosting;
        public WhoAmIController(IWhoService whoService, IWebHostEnvironment hosting)
        {
            _whoService = whoService;
            _hosting = hosting;
        }

        public IActionResult Index()
        {
            var Model = new WhoAmIViewModel
            {

                WhoAmI = _whoService.Get(1)

            };
            return View(Model);
        }
        [Authorize]
        public IActionResult Update()
        {
            var Model = new WhoAmIViewModel
            {
                WhoAmI = _whoService.Get(1)
            };
            return View(Model);
        }
        [Authorize]
        [HttpPost]
        public IActionResult Update(WhoAmI WhoAmI)
        {
            var path = Path.Combine(_hosting.WebRootPath, "CV");
            var imgPath = Path.Combine(_hosting.WebRootPath, "PersonelImage");
            
            string dir = imgPath;
            string[] imgFile;
            imgFile = Directory.GetFiles(dir);
            int numFilesimg = imgFile.Length;

            if (numFilesimg >= 1)
            {
                Directory.Delete(imgPath, true);
            }

            string dir2 = path;
            string[] files;
            files = Directory.GetFiles(dir2);
            int Filesimg = files.Length;

            if (Filesimg >= 1)
            {
                Directory.Delete(path, true);
            }

            if (!Directory.Exists(imgPath))
            {
                Directory.CreateDirectory(imgPath);
            }
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            using (var stream2 = new FileStream(Path.Combine(imgPath, WhoAmI.FileImg.FileName), FileMode.Create))
            {
                WhoAmI.FileImg.CopyTo(stream2);
            }

            using (var fileStream = new FileStream(Path.Combine(path, WhoAmI.File.FileName), FileMode.Create))
            {

                WhoAmI.File.CopyTo(fileStream);
            }
            WhoAmI.Pdf = WhoAmI.File.FileName;
            WhoAmI.ImgName = WhoAmI.FileImg.FileName;
            WhoAmI.Id = 1;

            _whoService.update(WhoAmI);

            return RedirectToAction("Index");
        }
    }
}
