using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
	public IActionResult Index(){
        return View();
    }
	
	// [Route("details")]
	public IActionResult Details(){
        return View();
    }
}