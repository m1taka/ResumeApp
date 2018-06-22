namespace ResumeApp.Helper
{

    using System.Collections.Generic;
    using System.Linq;
    using ResumeApp.Helper.External.Models;
    using System.Web;
    using System.Data;
    public class XMLReader
    {
        const string path = "~/XML/cv.xml";
        DataSet ds = new DataSet();  

        public IEnumerable<Resume> ReturnInfo()
        {
            string xmldata = HttpContext.Current.Server.MapPath(path);
            ds.ReadXml(xmldata);
            var info = new List<Resume>();
            info = (from rows in ds.Tables[0].AsEnumerable()
                    select new Resume
                    {   FName = rows[0].ToString(),
                        LName = rows[1].ToString(),
                        Address = rows[2].ToString(),
                        Mobile = rows[3].ToString(),
                        Email = rows[4].ToString(),    
                        Sex = rows[5].ToString(),
                        //DateofBirth = rows[6].ToString(),
                        Nationality = rows[7].ToString()
                       
                    }).ToList();
            return info;
        }

        public List<Employment> ReturnListOfEmployments()
        {
            string xmldata = HttpContext.Current.Server.MapPath(path);
            ds.ReadXml(xmldata);
            var employments = new List<Employment>();
            employments = (from rows in ds.Tables[1].AsEnumerable()
                           select new Employment
                           {
                               Position = rows[0].ToString(),
                               Company = rows[1].ToString(),

                           }).ToList();
            return employments;
        }

        public List<Education> ReturnListOfEducations()
        {
            string xmldata = HttpContext.Current.Server.MapPath(path);
            ds.ReadXml(xmldata);
            var educations = new List<Education>();
            educations = (from rows in ds.Tables[3].AsEnumerable()
                          select new Education
                          {      
                              Title = rows[0].ToString(),
                              University = rows[1].ToString(),
                              Speciality = rows[2].ToString(),
                          }).ToList();
            return educations;
        }  
    }
}
