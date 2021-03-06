﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetProject.Models;
using DotNetProject.Data;
using Microsoft.AspNetCore.Identity;
using System.Net;
using Newtonsoft.Json;

namespace DotNetProject.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext _context;
        UserManager<ApplicationUser> _userManager;
        public HomeController(ApplicationDbContext applicationDbContext, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = applicationDbContext;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated) {
                List<SubscriptionModel> subscriptions = new List<SubscriptionModel>();
                subscriptions = (from product in _context.SubscriptionModels where (product.UserId == _userManager.GetUserId(User)) select product).ToList();
                return View(subscriptions);
            }
            else
            {
                return View();
            }
            
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        

    }
}
