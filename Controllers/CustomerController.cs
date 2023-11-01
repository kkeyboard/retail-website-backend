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
        new Customer() {CustomerId = 101, CustomerName = "King",CustomerAmount = 12000},
        new Customer() {CustomerId = 101, CustomerName = "Queen", CustomerAmount = 20000},
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
        ViewData["Message"] = "Customer Management System";
        ViewData["CustomerCount"] = customers.Count();
        ViewData["CustomerList"] = customers;
        return View();
    }

    public IActionResult Method1()
    {
        TempData["Message"] = "Customer Management System";
        TempData["CustomerCount"] = customers.Count();
        TempData["CustomerList"] = customers;
        return View();
    }

    public IActionResult Method2()
    {
        if(TempData["Message"] == null)
        {
            return RedirectToAction("Index");
        }
            
        TempData["Message"] = TempData["Message"].ToString();
        return View();
    }

    public IActionResult Login()
    {
        HttpContext.Session.SetString("username", "J");
        return RedirectToAction("Success");
    }

    public IActionResult Success()
    {
        ViewBag.Username = HttpContext.Session.GetString("username");
        return View();
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Remove("username");
        return RedirectToAction("Index");
    }

    
    public IActionResult QueryTest()
    {
        string? name = "King Kong";
        if(!String.IsNullOrEmpty(HttpContext.Request.Query["name"]))
        {
            name = HttpContext.Request.Query["name"];
        }
        ViewBag.Name = name;
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