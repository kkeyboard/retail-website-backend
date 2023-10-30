using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web_app_1.Models;

namespace web_app_1.Controllers;

public class CustomerController : Controller
{
    public static List<Customer> customers = new List<Customer>()
    {
        new Customer() {Id = 101, Name = "King", Amount = 12000},
        new Customer() {Id = 101, Name = "Queen", Amount = 20000},
    };

    public IActionResult Index()
    {
        ViewBag.Message = "Customer Management System";
        ViewBag.CustomerCount = customers.Count();
        ViewBag.CustomerList = customers;
        return View();
    }

    public IActionResult Details()
    {
        return View();
    }

    // [Route("~/")] // overloads conventional routing
    // [Route("/sample/message")]
    public IActionResult Message()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }
}