using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contact.CRUD;
using System.Data;
namespace ContactMVC.Controllers
{
  public class ContactController : Controller
  {
    // GET: Contacts
    public ActionResult Index()
    {

      PersonCrud personCrud = new PersonCrud();
      DataTable tbl = personCrud.GetAllContact();
      return View(tbl);
    }

    [HttpPost]
    public ActionResult Delete(int id)
    {
      PersonCrud personCrud = new PersonCrud();
      personCrud.Delete(id);
      return RedirectToAction("Index");
    }

    [HttpGet]
    public ActionResult Detail(int id)
    {
      PersonCrud personCrud = new PersonCrud();
      DataTable tbl = personCrud.GetContactById(id);
      return View(tbl);
    }

    [HttpGet]
    public ActionResult Add()
    {
      return View();
    }
  }
}