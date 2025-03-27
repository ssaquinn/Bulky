using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BulkyWeb.Models;

namespace BulkyWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    // PUT IN A DIFFERENT PROGRAM
    //public ViewResult Details()
    //{
    //    ViewBag.Title = "Student Details Page";
    //    ViewData["Header"] = "Student Details";
    //    Student student = new Student()
    //    {
    //        StudentId = 101,
    //        Name = "James",
    //        Branch = "CSE",
    //        Section = "A",
    //        Gender = "Male"
    //    };
    //    ViewBag.Student = student;
    //    return View(student);
    //}

    //public IActionResult Index()
    //{
    //    TempData["Name"] = "Sarah";
    //    TempData["Role"] = "Loser";
    //    return View();
    //}

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
