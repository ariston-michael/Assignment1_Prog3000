using Assignment1_EquipmentTool.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_EquipmentTool.Controllers;

public class RequestFormController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(EquipmentRequest request)
    {
        if (ModelState.IsValid)
        {
            Repository.AddRequest(request);
            return RedirectToAction("Confirmation");
        }
        return View(request);
    }

    public IActionResult Confirmation()
    {
        return View();
    }

    [Route("Requests")]
    public IActionResult Requests()
    {
        return View(Repository.Requests);
    }
}