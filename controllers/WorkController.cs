using Microsoft.AspNetCore.Mvc;

public class WorkController : Controller
{
	[Route("Work/")]
	public IActionResult Index(){
        return Ok("All work and no play makes Jack a dull boy.");
    }
}