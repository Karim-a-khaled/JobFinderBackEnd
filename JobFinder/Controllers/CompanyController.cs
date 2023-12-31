﻿using JobFinder.Entities.DTOs.CompanyDTOs;
using JobFinder.Entities.Entities;
using JobFinder.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CompanyController : ControllerBase
    {
        private readonly CompanyService _companyService;
        public CompanyController(CompanyService companyService)
        {
            _companyService = companyService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> GetCompanies()
        {
            var companies = await _companyService.GetCompanies();
            if (companies is null)
                return NotFound("Companies Were Not Found");

            return Ok(companies);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Company>> GetCompany(int id)
        {
            var company = await _companyService.GetCompany(id);
            if (company is null)
                return NotFound("Company Not Found");

            return Ok(company);
        }

        [HttpDelete]
        public async Task<ActionResult<string>> DeleteCompany(int id)
        {
            var company = _companyService.DeleteCompany(id);
            if (company is null)
                return NotFound("C ompany Was Not Found");

            return Ok(company);
        }

        [HttpPut()]
        public async Task<ActionResult<string>> UpdateCompany(UpdateCompanyDto request)
        {
            var company = await _companyService.UpdateCompany(request);
            if (company is null)
                return NotFound("Company Was Not Found");

            
            return Ok("Updated Succesfully");
        }

    }
}
