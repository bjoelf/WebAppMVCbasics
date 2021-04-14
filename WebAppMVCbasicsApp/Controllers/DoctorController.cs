using Microsoft.AspNetCore.Mvc;
using WebAppMVCbasicsApp.Models;

namespace WebAppMVCbasicsApp.Controllers
{
    public class DoctorController : Controller
    {
        [HttpPost]
        public IActionResult FeverCheck(string temp)
        {
            if (string.IsNullOrWhiteSpace(temp))
            {
                ViewBag.Msg = "Pls enter your temperaure and then hit Submit";
                return View();
            } else {

                ViewBag.Msg = Medical.FeverTest(temp);
                return View();
            }
        }
        [HttpGet]
        public IActionResult FeverCheck()
        {
            return View();
        }
    }
}
