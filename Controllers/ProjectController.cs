using COMP2139_Labs.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP2139_Labs.Controllers;

public class ProjectController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var projects = new List<project>()
        {
            new project {ProjectId = 1, Name = "Project 1", Description = "First Project"}
        };
        return View(projects);
    }
    
    [HttpGet]
    public IActionResult Create()
    {
        return View();
          
    }
    
    [HttpPost]
    public IActionResult Create(project project)
    {
        return View();
        
    }
}