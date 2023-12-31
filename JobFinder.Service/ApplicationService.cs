﻿using JobFinder.Data;
using JobFinder.Entities.DTOs.ApplicationDTOs;
using JobFinder.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.Service
{

    public class ApplicationService
    {
        private readonly AppDbContext _context;
        private readonly UserService _userService;
        private readonly FileService _fileService;

        public ApplicationService(AppDbContext context, UserService userService, FileService fileService)
        {
            _context = context;
            _userService = userService;
            _fileService = fileService;
        }

        public async Task<IEnumerable<Application>> GetApplications()
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

        public async Task<Application> AddApplication(AddOrUpdateApplicationDto applicationDto)
        {
            var existingApplication = await _context.Applications.FindAsync();
            var userId = _userService.GetUserId();

            if (existingApplication != null)
            {
                throw new Exception("A job application with the same title and description already exists.");
            }

            var applicationToAdd = new Application
            {
                CoverLetter = applicationDto.CoverLetter,
                CreationDate = DateTime.Now.Date,
                JobId = applicationDto.JobId,
                JobSeekerId = (int)userId
            };

            await _context.AddAsync(applicationToAdd);
            await _context.SaveChangesAsync();

            return applicationToAdd;
        }

        public async Task<string> DeleteApplication(int id)
        {
            var application = _context.Applications.FirstOrDefault(a => a.Id == id);
            if (application is null)
                return null;

            _context.Applications.Remove(application);
            await _context.SaveChangesAsync();
            return "Deleted Succesfuly";
        }
    }
}
