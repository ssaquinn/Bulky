using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BulkyWeb.Models;
using Sd7501Bulky.DataAccess.Repository.IRepository;
using SD7501Bulky.Models;

namespace BulkyWeb.Areas.Customer.Controllers;

[Area("Customer")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUnitOfWork _unitOfWork;

    public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;
    }

    public IActionResult Index()
    {
        IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includeProperties: "Category");
        return View(productList);
    }

    public IActionResult Details(int productId)
    {
        Product product = _unitOfWork.Product.Get(u => u.Id == productId, includeProperties: "Category");
        return View(product);
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
