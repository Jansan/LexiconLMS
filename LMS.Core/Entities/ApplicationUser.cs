﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;


namespace LMS.Core.Entities {
    public class ApplicationUser : IdentityUser
    {
       // public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
       // public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public int? CourseId { get; set; }
        //Navigation property
        public Course Course { get; set; }
        public ICollection<Document> Dokuments { get; set; }
    }
}
