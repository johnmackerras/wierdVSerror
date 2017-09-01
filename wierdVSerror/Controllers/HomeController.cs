using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wierdVSerror.Models;

namespace wierdVSerror.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Family family = new Family
            {
                FamilyName = "Smith",
                Children = new List<Child> 
                {
                    new Child { Name = "Samantha"},       
                    new Child { Name = "Julie"},       
                    new Child { Name = "Michael"},       
                    new Child { Name = "Terrance"},
                    new Child { Name = "Joseph"},       
                }
            };
            return View(family);
        }

        [HttpPost][ValidateAntiForgeryToken]
        public ActionResult Index(Family family, string btn)
        {
            if (!String.IsNullOrEmpty(btn))
            {
                try
                {
                    int i = Convert.ToInt32(btn);
                    family.Children.Remove(family.Children[i]);
                }
                finally { };
            }
            
            
            return View(family);
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}