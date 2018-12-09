using System.Web.Mvc;
using Contact.Model;
using Contact.CRUD;

namespace ContactMVC.Controllers
{
  [IsAuthenticated]
  public class GroupController : Controller
  {
    // GET: Group
    public ActionResult Index()
    {
      return View(new Group());
    }

    [HttpPost]
    public ActionResult Index(Group group)
    {
      if (ModelState.IsValid)
      {
        GroupCRUD groupCRUD = new GroupCRUD();
        groupCRUD.Add(group);
        return RedirectToAction("Index");
      }
      return View(group);
    }

    [HttpPost]
    public ActionResult Delete(int id)
    {
      GroupCRUD group = new GroupCRUD();
      group.Delete(id);
      return RedirectToAction("Index");
    }
  }
}