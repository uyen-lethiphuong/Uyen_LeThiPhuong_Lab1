using Microsoft.AspNetCore.Mvc;
using Uyen_LeThiPhuong_Lab1.Models;

namespace Uyen_LeThiPhuong_Lab1.Controllers
{
    // 1. Đổi tên class bỏ số 1 đi để khớp với thư mục Views/Student
    public class StudentController : Controller
    {
        // 2. Đổi tên hàm thành Info để khớp với file Info.cshtml
        public IActionResult Info()
        {
            var student = new Student { Name = "Ana", Age = 21 };
            return View(student);
        }
    public IActionResult TestViewBag()
        {
            // 1. Sử dụng ViewBag (Kiểu dynamic)
            ViewBag.Message = "Mesaj din Controller (Thông điệp từ Controller)";

            // 2. Sử dụng ViewData (Kiểu Dictionary key-value)
            ViewData["Time"] = DateTime.Now;

            return View();
        }
    }
}
