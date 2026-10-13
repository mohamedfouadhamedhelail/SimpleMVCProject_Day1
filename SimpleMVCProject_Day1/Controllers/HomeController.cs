
using Microsoft.AspNetCore.Mvc;
using SimpleMVCProject_Day1.Models;
namespace SimpleMVCProject.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }


    public IActionResult About()
    {
      Student student = new Student
      {
        Name = "Mohamed Fouad",
        Department = "Information Technology",
        Age = 25
      };

      return View(student);
    }

    public IActionResult Contact()
    {
      return Content("Contact Us");
    }
  }

}

