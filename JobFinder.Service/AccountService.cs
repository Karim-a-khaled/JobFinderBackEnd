﻿using JobFinder.Data;
using JobFinder.Entities.DTOs.AccountDTOs;
using JobFinder.Entities.Entities;
using JobFinder.Entities.Entities.UserManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics.Eventing.Reader;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace JobFinder.Service
{
    public class AccountService
    {
        private readonly IConfiguration _configuration;
        private readonly AppDbContext _context;
        public AccountService(IConfiguration configuration, AppDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        public async Task<User> Register(RegisterDto request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email); 
            if (user != null)
                return null;

            user = new User
            {
                Email = request.Email,
                IsCompany = request.IsCompany,
                Password = request.Password,
                CreationDate = DateTime.Now
            };
            
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            
            if (request.IsCompany)
            {
                var company = new Company
                {
                    UserId = user.Id,
                };
                await _context.Companies.AddAsync(company);
            }

            else
            {
                var jobSeeker = new JobSeeker
                {
                    UserId = user.Id
                };
                await _context.JobSeekers.AddAsync(jobSeeker);
            }
            
            await _context.SaveChangesAsync();
            
            return user;
        }

        public async Task<string> Login(LoginDto request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email);
            if (user is null)
                return null;

            if (user.Password != request.Password)
                return null;

            string token = CreateToken(user);

            return token;
        }

        public string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Role, user.IsCompany? "Company" : "JobSeeker")
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}
