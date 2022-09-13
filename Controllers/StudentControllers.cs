 
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VuKhacTruongBTH.Models;
namespace DemoMVC.Controllers
{
    public class StudentControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        
    
        public IActionResult Create(Student std)
        {
        string message = std.StudentID + "-";
        message += std.StudentName + "-";
        message += std.Age;
        ViewBag.TT = message;
        return View();
        }
      
    }    
}
   
