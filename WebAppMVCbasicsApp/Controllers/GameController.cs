using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVCbasicsApp.Models;



namespace WebAppMVCbasicsApp.Controllers
{
    public class GameController : Controller
    {
        [HttpPost]
        public IActionResult GuessingGame(int userGuess)
        {
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("intRnd")) && userGuess > 0)
            {
                int storedRnd = (int)HttpContext.Session.GetInt32("intRnd");
                string respons = RandomNumberGuess.MatchGuess(Convert.ToInt32(userGuess), storedRnd);
                ViewBag.Msg = respons;
            }
            else 
            {
                ViewBag.Msg = "Enter a number and hit Submit";
            }
            return View();
        }

        [HttpGet]
        public IActionResult GuessingGame()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("intRnd")))
            {
                int getRnd = RandomNumberGuess.GetRandom(100);
                HttpContext.Session.SetInt32("intRnd", getRnd);
                ViewBag.Rnd = getRnd;
            }
            else if (true)
            {
                ViewBag.Rnd = HttpContext.Session.GetInt32("intRnd");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Reset()
        {
            int getRnd = RandomNumberGuess.GetRandom(100);
            HttpContext.Session.SetInt32("intRnd", getRnd);
            ViewBag.Rnd = getRnd;
            return RedirectToAction(nameof(GuessingGame));
        }
    }
}
