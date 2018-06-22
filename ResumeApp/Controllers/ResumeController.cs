using ResumeApp.Helper.External.Models;
using System.IO;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace ResumeApp.Controllers
{
    public class ResumeController : Controller
    {
        // GET: Info
        public ActionResult Index(string id)
        {
            //XMLReader readXML = new XMLReader();
            //var data = readXML.ReturnInfo();
            //return View(data.ToList());
            return View();
        }

        //Show detailed view of the resume
        public ActionResult Details(string id)
        {
            Resume resume = LoadFromXml(id);
            TempData["fileid"] = id;
            return View(resume);
        }   

        //Get the resume form for editing
        public ActionResult Edit(string id)
        {
            Resume resume = LoadFromXml(id);
            TempData["fileid"] = id;

            return View(resume);
        }  

        //Save edited resume form
        [HttpPost]
        public ActionResult Edit(Resume resume, string id)
        {
            if (ModelState.IsValid)
            {
                var path = FileIdToPath(id);
                using (StreamWriter writer = new StreamWriter(path))
                {
                    XmlSerializer s = new XmlSerializer(resume.GetType());
                    s.Serialize(writer.BaseStream, resume);
                }
                return RedirectToAction("Details", new { id=id});
            }
            else
            {
                TempData["fileid"] = id;
                return View(resume);
            }
        } 
        
        //Load resume from .xml format
        private Resume LoadFromXml(string fileId)
        {
            //var path = "D:/Projects/ResumeApp/ResumeApp/XML/cv.xml";
            var path = FileIdToPath(fileId);

            Resume resume = new Resume();
            using (StreamReader reader = new StreamReader(path))
            {
                //XmlRootAttribute xRoot = new XmlRootAttribute();
                //xRoot.ElementName = "Resume";
                //xRoot.IsNullable = true;

                XmlSerializer serializer = new XmlSerializer(resume.GetType());
                
                resume = serializer.Deserialize(reader.BaseStream) as Resume;
            }   
            return resume;
        }
        
        //return path of the .xml file
        private string FileIdToPath(string fileId)
        {
            return Path.Combine(Server.MapPath("~/XML"), fileId + "cv.xml");
        }      
    }
}