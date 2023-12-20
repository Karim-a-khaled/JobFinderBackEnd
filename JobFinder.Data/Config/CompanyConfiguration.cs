﻿using JobFinder.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder.Data.Config
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        // implemented in Apllication Configuration
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            // implemented in Application Configuration
            // implemented in User Configuration
        }
    }
}
