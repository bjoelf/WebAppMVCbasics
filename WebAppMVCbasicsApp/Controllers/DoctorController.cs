using Microsoft.AspNetCore.Mvc;
using WebAppMVCbasicsApp.Models;

namespace WebAppMVCbasicsApp.Controllers
{
    public class DoctorController : Controller
    {
        [HttpPost]
        public IActionResult FeverCheck(float temp)
        {
            if (temp != 0)
            {

                ViewBag.Msg = Medical.FeverTest(temp);
                return View();
            }
            else
            {
                ViewBag.Msg = "Pls enter your temperaure and then hit Submit";
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
