
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Liikunta.Controllers;

public class CityController : Controller
{
    // 
    // GET: /HelloWorld/
    //public string Index()
    //{
    //    return "This is my default action...";
    //}

    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public string Welcome()
    {
        return "This is the Welcome action method...";
    }
}