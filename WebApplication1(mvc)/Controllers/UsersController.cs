using Microsoft.AspNetCore.Mvc;
using WebApplication1_mvc_.Data;
using WebApplication1_mvc_.Models;

namespace WebApplication1_mvc_.Controllers
{
    public class UsersController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        //Read [CRUD]
        public ViewResult Index()
        {
            var products = context.Users.ToList();
            return View("Index", products);
        }
        //Create
        public ViewResult Create()
        {
            return View("Create", new Users());
        }

        public IActionResult Store(Users request)
        {
            if (ModelState.IsValid)
            {
                context.Users.Add(request);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Create", request);
           
        }

        //Details
        public IActionResult Details(int id)
        { 
           var user = context.Users.Find(id);
            return View("Details", user);
        }

        //Edit button
        public IActionResult Edit(int id)
        {
            var user = context.Users.Find(id);
            return View("Edit", user);
        }

        //Uodate
        public IActionResult Update(Users request, int id)
        {
            request.Id = id;
            context.Users.Update(request);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        //Delete
        public IActionResult Delete(int id)
        {
            var user = context.Users.Find(id);
            context.Users.Remove(user);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
