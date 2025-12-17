using Microsoft.AspNetCore.Mvc;

namespace Uyen_LeThiPhuong_Lab1.Controllers
{
    public class DemoController : Controller
    {
        [Route("hello")]
        public string Hello()
        {
            return "Salut!";
        }

        // 2. Đường dẫn có tham số: /hello/TenCuaBan
        // [HttpGet] nghĩa là chỉ nhận yêu cầu GET (truy cập trình duyệt)
        [HttpGet("hello/{name}")]
        public string HelloByName(string name)
        {
            return $"Salut, {name}!";
        }

       
        [HttpGet("calc/{a:int}/{b:int}")]
        public string Calculate(int a, int b)
        {
            return $"Suma este: {a + b}";
            // Nghĩa là: Tổng là (a + b)
        }
    }
}

