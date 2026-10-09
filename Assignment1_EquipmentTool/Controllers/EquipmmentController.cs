using Assignment1_EquipmentTool.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_EquipmentTool.Controllers;

public class EquipmentController : Controller
{
    [Route("/AllEquipment")]
    public IActionResult AllEquipment()
    {
        return View(Repository.Equipment);
    }

    [Route("/AviableEquipment")]
    public IActionResult AvailableEquipment()
    {
        var availableEquipment = Repository.Equipment.Where(e => e.Available);
        return View(availableEquipment);
    }
}