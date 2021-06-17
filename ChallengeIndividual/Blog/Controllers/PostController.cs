using Blog.Data;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class PostController : Controller
    {
        private readonly BlogDbContext _db;

        public PostController(BlogDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Post> postList = _db.Posts;
            return View(postList);
        }
        //Get-Create
        public IActionResult Create()
        {
            return View();
        }
        //POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Post obj)
        {
            if(ModelState.IsValid)
            {
                _db.Posts.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        //Get-Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Posts.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        //POST-Delete
        //[HttpDelete]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Posts.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Posts.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        //GET Update
        public IActionResult Update(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Posts.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        //Post Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Post obj)
        {
            if(ModelState.IsValid)
            {
                _db.Posts.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
