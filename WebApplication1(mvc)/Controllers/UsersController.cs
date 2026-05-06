using Microsoft.AspNetCore.Mvc;
using WebApplication1_mvc_.Data;
using WebApplication1_mvc_.Models;

namespace WebApplication1_mvc_.Controllers
{
    public class UsersController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public ViewResult Index()
        {
            var products = context.Users.ToList();
            return View("Index", products);
        }
        public ViewResult Create()
        {
            return View("Create");
        }
        public ViewResult Store(Users request)
        {
            context.Users.Add(request);
            context.SaveChanges();
            return View("Create");
        }
    }
}
