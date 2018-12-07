using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Helpers;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private List<Contact> _contactList;
        // GET: Home
        public ActionResult Index()
        {
            if (Session["userData"] == null)
            {
                Session["userData"] = ContactHelper.SeedContacts();
            }

            return View(Session["userData"]);
        }

        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            _contactList = new List<Contact>();
            _contactList = (List<Contact>)Session["userData"];

            if (_contactList.Count(x => x.Email == contact.Email) >= 1)
            {
                ModelState.AddModelError("", "Erreur : Email déjà existant");
                return View(Session["userData"]);
            }

            if (contact.BirthDate > DateTime.Now)
            {
                ModelState.AddModelError("", "Erreur : Date de naissance invalide");
                return View(Session["userData"]);
            }

            contact.Id = Guid.NewGuid();
            _contactList.Add(contact);
            Session["userData"] = _contactList;
            return View(Session["userData"]);
        }
    }
}