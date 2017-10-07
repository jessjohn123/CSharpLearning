using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMVCWebApp2.Models;

namespace MyMVCWebApp2.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class PaymentInfoController : Controller
    {
        public IActionResult Index()
        {
            return View("Create");
        }

        //[ValidateAntiForgeryToken]
        public IActionResult Create([Bind("CardNumber", "ExpireMonth","ExpireYear", "Name", "Email")]PaymentInfo pInfo)
        {
            if(ModelState.IsValid)
            {
                return View("Success");
            }
            else
            {
                return View("Failure");
            }
        }
    }
}