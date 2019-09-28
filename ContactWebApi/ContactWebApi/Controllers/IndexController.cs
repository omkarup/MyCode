using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactWebApi.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            masterEntities entity = new masterEntities();
            List<Contact> contacts = entity.Contacts.ToList();
            if (contacts.Count == 0)
            {
                contacts.Add(new Contact());
            }

            return View(contacts);
        }
    }
}
