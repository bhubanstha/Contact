using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity = Contact.Model;

namespace ContactMVC.Controllers
{
  public class HomeController : Controller
  {
    [IsAuthenticated]
    public ActionResult Index()
    {
      return View();
    }
  }
}