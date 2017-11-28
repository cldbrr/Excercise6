using Exercise6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercise6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult CheckPalindrome()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CheckPalindrome(Palindrome palindrome)
        {
            if (ModelState.IsValid)
            {
                if (palindrome.IsPalindrome)
                {
                    TempData["ResultMessage"] = string.Format("Given number {0} is a palindrome", palindrome.PalindromeValue);
                }
                else
                {
                    TempData["ResultMessage"] = string.Format("Given number {0} is NOT a palindrome", palindrome.PalindromeValue);
                }

                return RedirectToAction("CheckPalindrome");

            }

            return View(palindrome);
        }

    }
}