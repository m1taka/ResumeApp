using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace ResumeApp.Helper.External.Models
{
    [Serializable]
    [XmlRoot("Resume"), XmlType("Resume")]
    public class Resume
    {
        [XmlAttribute("Id")]          
        public string Id { get; set; }
        [Display(Name = "First name: ")]
        [Required(ErrorMessage ="Please write your 'First name'")]
        public string FName { get; set; }

        [Display(Name = "Last name: ")]
        [Required(ErrorMessage = "Please write your 'Last name'")]
        public string LName { get; set; }

        [Display(Name ="Address: ")]
        public string Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone number: ")]
        [Required(ErrorMessage = "Please input 'Phone number'")]
        public string Mobile { get; set; }
        [Display(Name = "Email: ")]
        public string Email { get; set; }
        [Display(Name = "Sex: ")]
        public string Sex { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date of birth: ")]
        public DateTime DateofBirth { get; set; }
        [Display(Name ="Nationality: ")]
        public string Nationality { get; set; }

        public List<Employment> Employments { get; set; }
        public List<Education> Educations { get; set; } 
    }
}
