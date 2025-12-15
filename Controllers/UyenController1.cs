using Microsoft.AspNetCore.Mvc;

namespace Uyen_LeThiPhuong_Lab1.Controllers
{
    public class UyenController1 : Controller
    {
        public string Index()
        {
            return "Bun venit!";
        }

       
        public string Hello()
        {
            return "Salut!";
        }

  
        public string Mesajpersonalizat(string nume, int varsta)
        {
            return $"Salut {nume} ai varsta de {varsta} ani.";
        }
    }
}
