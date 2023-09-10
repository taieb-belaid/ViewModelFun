using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpGet("")]
    public IActionResult Index()
    {
        string Message ="Lorem ips    Lorem ipsum, dolor sit amet consectetur adipisicing elit. Commodi consequatur ipsum quidem, delectus dicta numquam quasi sed rerum aspernatur adipisci quo nisi voluptas dignissimos dolorem nobis totam perferendis. Quo, consequuntur?";
        return View("Index",Message);
    }

    [HttpGet("numbers")]
    public IActionResult Numbers(){
        int [] numbers = {1,2,3,4,5,6,7,8,9};
        return View(numbers);
    }

    [HttpGet("user")]
    public IActionResult User()
    {
        User newUser = new User ()
        {
            FirstName = "Taieb",
            LastName = "Belaid"
        }; 
        return View("User",newUser);
    }

    [HttpGet("users")]
    public IActionResult Users(){
        List <string> names = new List <string> () {"Moose Philip","Sarah","Jerry","Rene Ricky","Barbarah"};
        return View(names);
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    
}
