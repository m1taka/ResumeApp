using ResumeApp.Helper;
using System.Linq;
using System.Web.Mvc;

namespace ResumeApp.Controllers
{
    public class EducationController : Controller
    {
        
        // GET: Education
        [HttpGet]
        public ActionResult Index()
        {
            XMLReader readXML = new XMLReader();
            var data = readXML.ReturnListOfEducations();
            return View(data.ToList());
        }  
    }
}
