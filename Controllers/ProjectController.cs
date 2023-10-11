using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectApi.Models;
using AutoMapper;
namespace ProjectApi.Controllers;
using System.Text.Json;

    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly ProjectsDbContext _context;

        public ProjectController(ProjectsDbContext context)
        {
            _context = context;
           
       }

        // POST: api/Movies
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
   
        public async Task<ActionResult<Project>> PostProject(Project project)
        {
           _context.data.Add(project.Data);
          
            await _context.SaveChangesAsync();
            var response = HttpContext.Response.StatusCode;
            if(response == 200)
                return Content("Success");
            else 
                return Content("Failed");
        }

    }
