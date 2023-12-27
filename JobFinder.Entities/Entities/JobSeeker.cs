﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using JobFinder.Entities.Entities.UserManagement;

namespace JobFinder.Entities.Entities
{
    public class JobSeeker : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int YearsOfExperience { get; set; }
        public bool IsFresh { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Application> Applications { get; set; }

    }
}
