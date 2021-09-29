using System;
using System.ComponentModel.DataAnnotations;

namespace Personal.Models
{
    public class PersonalInformation
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName{get;set;}
        public int Age{get;set;}
        public string Gender { get; set; }
        public string Hobbies{get;set;}
        public string interestingAboutme{get;set;}
    }
}