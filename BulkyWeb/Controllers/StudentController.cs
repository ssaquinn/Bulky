
//using BulkyWeb.ViewModels;
//using BulkyWeb.Models;
//using Microsoft.AspNetCore.Mvc;


//namespace BulkyWeb.Controllers
//{
//    public class StudentController : Controller
//    {
//        public ViewResult Details()
//        {
//            Student student = new Student()
//            {
//                StudentId = 101,
//                Name = "Dillip",
//                Branch = "CSE",
//                Section = "A",
//                Gender = "Male"
//            };

//            Address address = new Address()
//            {
//                StudentId = 101,
//                City = "Mumbai",
//                State = "Maharashtra",
//                Country = "India",
//                Pin = "40097"
//            };

//            StudentDetailsViewModel studentDetailsViewModel = new StudentDetailsViewModel()
//            {
//            Student = student,
//            Address = address,
//            Title = "Student Details Page",
//            Header = "Student Details",

//            };

//            return View(studentDetailsViewModel);
//        }
//        public IActionResult Index()
//        {
//            return View();
//        }
//    }
//}
