using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Entity = Contact.Model;

namespace ContactMVC.Controllers
{
  public class IsAuthenticatedAttribute : ActionFilterAttribute
  {
    public override void OnActionExecuting(ActionExecutingContext filterContext)
    {
      //do your validations here. and redirect to somewhere if needed. 
      if (Entity.User.UserName == null)
      {
        filterContext.HttpContext.Response.Redirect("/user/login"); //this will send user to home.
      }
    }
  }
}