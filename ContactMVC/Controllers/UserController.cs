using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity= Contact.Model;
using Contact.CRUD;
using System.Data;

namespace ContactMVC.Controllers
{
  public class UserController : Controller
  {
  [HttpGet]
  public ActionResult Index()
  {
      return RedirectToActionPermanent("Login");
  }

    // GET: Login
    public ActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Login(string userName, string password)
    {
      if (ModelState.IsValid)
      {
        UserCrud userCrud = new UserCrud();
        DataTable tbl = userCrud.GetUser(password, userName);
        if(tbl.Rows.Count>0)
        {
          Entity.User.Id = Convert.ToInt32(tbl.Rows[0]["ID"]);
          Entity.User.UserName = tbl.Rows[0]["UserName"].ToString();
          Entity.User.Email = tbl.Rows[0]["Email"].ToString();
          Entity.User.Mobile = tbl.Rows[0]["Mobile"].ToString();
          Entity.User.Mobile1 = tbl.Rows[0]["Mobile1"].ToString();
          Entity.User.Birthday = tbl.Rows[0]["Birthday"] == DBNull.Value? DateTime.MinValue: Convert.ToDateTime(tbl.Rows[0]["Birthday"]);
          Entity.User.Address = tbl.Rows[0]["Address"].ToString();
          Entity.User.Name = tbl.Rows[0]["Name"].ToString();
          return RedirectToAction("Index", "Home");
        }
      }
      return View();      
    }

    [HttpGet]
    public ActionResult Logout()
    {
      Entity.User.Id = 0;
      Entity.User.UserName =null;
      Entity.User.Email = null;
      Entity.User.Mobile = null;
      Entity.User.Mobile1 = null;
      Entity.User.Birthday = DateTime.MinValue;
      Entity.User.Address =null;
      Entity.User.Name = null;
      return RedirectToAction("login");
    }

    [HttpGet]
    [IsAuthenticated]
    public new ActionResult Profile()
    {
      return View();
    }

    [HttpGet]
    [IsAuthenticated]
    public ActionResult ChangePassword()
    {
      return View();
    }

    [HttpPost]
    [IsAuthenticated]
    public ActionResult Changepassword(string password, string password1)
    {
      if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(password1))
      {
        TempData["ErrorMessage"] = "Enter both password and confirmation password";
      }
      else if (string.Equals(password, password1, StringComparison.Ordinal))
      {
        UserCrud userCrud = new UserCrud();
        userCrud.ChangePassword(password, Contact.Model.User.UserName);
      }
      else{
        TempData["ErrorMessage"] = "Incorrect password and confirmation password";
      }

      return View();
    }
  }
}