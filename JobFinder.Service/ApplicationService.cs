﻿using JobFinder.Data;
using JobFinder.Entities.DTOs;
using JobFinder.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder.Service
{

        public class ApplicationService
        {
            private readonly AppDbContext _context;

            public ApplicationService(AppDbContext context)
            {
                _context = context;
            }

            public async Task<List<Application>> GetApplications()
            {
                var applications = await _context.Applications.ToListAsync();
                return applications;
            }

            public async Task<Application> GetApplication(int id)
            {
                var application = await _context.Applications.FirstOrDefaultAsync(a => a.Id == id);
                if (application is null)
                    return null;

                return application;
            }

            public async Task<Application> AddApplication(ApplicationDto applicationDto)
            {
                var existingApplication = await _context.Applications
                    .FindAsync();

                if (existingApplication != null)
                {
                    throw new Exception("A job application with the same title and description already exists.");
                }

                var applicationToAdd = new Application
                {
                    IsSubmitted = applicationDto.IsSubmitted,
                    CoverLetter = applicationDto.CoverLetter,
                    CreationDate = DateTime.Now,
                };
            

                await _context.AddAsync(applicationToAdd);
                await _context.SaveChangesAsync();

                return applicationToAdd;
            }
        }
}