
using Microsoft.AspNetCore.Mvc ;
using VuKhacTruongBTH.Models.Process;


namespace VuKhacTruongBTH.Controllers
{
      public class DemoController : Controller
    {
        // tao cac action thuc thi cac nhiem vu 
       
        public IActionResult Index()
        {
            return View();
        }
    }
[HttpPost]
public IActionResult Index (string heSoA, string heSoB)
{
    double a = Convert.ToDouble(heSoA);
    double b = Convert.ToDouble(heSoB);
    string message = gpt.GiaiphuongtrinhBacnhat(a,b);
    ViewBag.mess = message;
    return View();
}
[HttpPost]
public IActionResult Create(string heSoA, string heSoB, string heSoC)
{
    double a =Convert.ToDouble(heSoA);
    double b =Convert.ToDouble(heSoB);
    double c =Convert.ToDouble(heSoC);

    string message = gpt.GiaiphuongtrinhBacHai(a , b ,c );
    return View();
}

}


 
    
