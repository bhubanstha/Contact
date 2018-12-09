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
    [IsAuthenticated]
    public ActionResult Index()
    {

      PersonCrud personCrud = new PersonCrud();
      DataTable tbl = personCrud.GetAllContact();
      return View(tbl);
    }

    [HttpPost]
    [IsAuthenticated]
    public ActionResult Delete(int id)
    {
      PersonCrud personCrud = new PersonCrud();
      personCrud.Delete(id);
      return RedirectToAction("Index");
    }

    [HttpGet]
    [IsAuthenticated]
    public ActionResult Detail(int id)
    {
      PersonCrud personCrud = new PersonCrud();
      DataTable tbl = personCrud.GetContactById(id);
      return View(tbl);
    }

    [HttpGet]
    [IsAuthenticated]
    public ActionResult Add()
    {
      return View(new ContactMVC.Models.ContactPerson());
    }

    [HttpPost]
    [IsAuthenticated]
    public ActionResult Add(ContactMVC.Models.ContactPerson person)
    {
      if (ModelState.IsValid)
      {
        Contact.Model.Person p = person;
        p.ImageName = GetPictureName(person.ProfilePicture);
        PersonCrud personCrud = new PersonCrud();
        personCrud.Add(p);
        return RedirectToAction("Add");
      }
      return View(person);
    }

    [HttpGet]
    [IsAuthenticated]
    public ActionResult Edit(int id)
    {
      PersonCrud personCrud = new PersonCrud();
      DataTable tbl = personCrud.GetContactById(id);
      Models.ContactPerson person = new Models.ContactPerson().GetPerson(tbl.Rows[0]);
      return View(person);
    }

    [HttpPost]
    [IsAuthenticated]
    public ActionResult Edit(Models.ContactPerson person)
    {
      if(ModelState.IsValid)
      {
        Contact.Model.Person p = person;
        p.ImageName = GetPictureName(person.ProfilePicture);
        PersonCrud personCrud = new PersonCrud();
        personCrud.Update(p, person.Id);
        return RedirectToAction("Index");
      }
      return View(person);
    }

    [HttpGet]
    [IsAuthenticated]
    public ActionResult Search(string q)
    {
      PersonCrud personCrud = new PersonCrud();
      DataTable tbl = personCrud.GetAllContact();
      if (!string.IsNullOrEmpty(q))
      {
        string filter = string.Format("FullName Like '%{0}%' OR PrimaryEmail like '%{0}%' OR Company Like '%{0}%'", q);
        DataRow[] rows = tbl.Select(filter);
        return View(rows);
      }
      DataRow[] rows1 = tbl.Select();
      return View(rows1);
    }

    private string GetPictureName(HttpPostedFileBase pic)
    {
      if (pic != null && pic.ContentLength > 0)
      {
        string fileName = Guid.NewGuid().ToString("N") + ".png";
        string path = Server.MapPath(@"~\Content\Images\Profile\" + fileName);
        pic.SaveAs(path);
        return fileName;
      }
      return "";
    }
  }
}