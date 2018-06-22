using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace ResumeApp.Helper.External.Models
{
    [Serializable]
    [XmlRoot("Education"), XmlType("Education")]
    public class Education
    {
        [XmlAttribute("Id")]
        public string Id { get; set; }
        [Display(Name = "Title: ")]
        public string Title { get; set; }
        [Display(Name = "University: ")]
        public string University { get; set; }
        [Display(Name = "Speciality: ")]
        public string Speciality { get; set; }
        [Display(Name = "Subjects: ")]
        public List<Subject> Subjects { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter 'From Date'")]
        [Display(Name = "From: ")]
        public DateTime DateStart { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter valid 'To Date'")]
        [Display(Name = "To: ")]
        public DateTime DateEnd { get; set; }
    }

    [Serializable]    
    public class Subject
    {
        [XmlAttribute("Id")]
        public string Id { get; set; }
        public string Sub { get; set; }
    }
}
