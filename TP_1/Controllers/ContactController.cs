using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP_1.Models;

namespace TP_1.Controllers
{
    public class ContactController : Controller
    {

        [HttpGet]
        public ActionResult ContactForm()
        {
            return View();

        }

        [HttpPost]
        public ActionResult ContactForm(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                InsertContact(model.Name, model.Email, model.Comments);
                TempData["notice"] = "Your form was submitted.";
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        private void InsertContact(string name, string email, string comments)
        {

        }

    }
}
