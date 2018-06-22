using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace ResumeApp.Helper.External.Models
{
    [Serializable]
    [XmlRoot("Employment"), XmlType("Employment")]
    public class Employment
    {
        [XmlAttribute("Id")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Please write 'Job Title'")]
        [Display(Name = "Job Title: ")]
        public string Position { get; set; }
        [Display(Name = "Company:")]
        public string Company { get; set; }
        public List<Task> Tasks { get; set; }

        [Required(ErrorMessage = "Please input 'From Date'")]
        [DataType(DataType.Date)]
        [Display(Name = "From:")]
        public DateTime DateStart { get; set; }

        [Required(ErrorMessage = "Please input 'To Date'")]
        [DataType(DataType.Date)]
        [Display(Name = "To:")]
        public DateTime DateEnd { get; set; }
    }

    [Serializable]
    public class Task
    {
        [XmlAttribute("Id")]
        public string Id { get; set; }
        public string T { get; set; }
    }
}
