using ResumeApp.Helper;
using System.Linq;
using System.Web.Mvc;

namespace ResumeApp.Controllers
{
    public class EmploymentController : Controller
    {
        // GET: Employment
        public ActionResult Index()
        {
            XMLReader readXML = new XMLReader();
            var data = readXML.ReturnListOfEmployments();
            return View(data.ToList());
        }
    }
}