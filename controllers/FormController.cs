using Microsoft.AspNetCore.Mvc;

public class FormController : Controller
{
	[HttpGet]
	public IActionResult Index()
	{
		return View();
	}

	[HttpPost, ValidateAntiForgeryToken]
	public IActionResult Index(FormModel model)
	{
		return Content($"Hello {model.FirstName} {model.LastName}. How are you?");
	}   
}