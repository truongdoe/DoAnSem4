using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DoAN_S4.Areas.Admin.Models.BussinesModel.IRepository;
using DoAN_S4.Models.DataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoAN_S4.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        IRepositoryBlog repositoryBlog;
        public BlogController(IRepositoryBlog repositoryBlog)
        {
            this.repositoryBlog = repositoryBlog;
        }
        // GET: Blog
        
        public ActionResult Index()
        {
            var data = repositoryBlog.getAll();

            return View(data);
        }

        // GET: Blog/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Blog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Blog/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Blog blog, IFormCollection collection)
        {
            // upload file vào thư mục wwwroot/Product
            var files = HttpContext.Request.Form.Files;
            //using System.Linq;
            if (files.Count() > 0 && files[0].Length > 0)
            {
                var file = files[0];
                var FileName = file.FileName;
                // Nhớ tạo thư mục avatar trong thư mụcwwwroot/images
                //using System.IO;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                    blog.Image = FileName; // gán tên ảnh cho thuộc tính Avatar
                }
            }
            repositoryBlog.Insert(blog);
            return RedirectToAction(nameof(Index));
        }

        // GET: Blog/Edit/5
        public ActionResult Edit(string id)
        {
            var b = repositoryBlog.GetByID(id);
            return View(b);
        }

        // POST: Blog/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Blog blog)
        {
            if (ModelState.IsValid)
            {
                // upload file vào thư mục wwwroot/Product
                var files = HttpContext.Request.Form.Files;
                //using System.Linq;
                if (files.Count() > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var FileName = file.FileName;
                    // Nhớ tạo thư mục avatar trong thư mụcwwwroot/images
                    //using System.IO;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        blog.Image = FileName; // gán tên ảnh cho thuộc tính Avatar
                    }
                }
            }
            repositoryBlog.Update(blog);
            return RedirectToAction(nameof(Index));
        }

        
        public ActionResult Delete(string id)
        {
            repositoryBlog.Delete(id);
            return RedirectToAction(nameof(Index));
        }

       
    }
}