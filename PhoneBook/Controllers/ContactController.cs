using Microsoft.AspNetCore.Mvc;
using PhoneBook.Models;
namespace PhoneBook.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Create(Contact collection)
    {
        string contact = collection["Name"];

        return View();
    }
    public IActionResult Edit()
    {
        return View();
    }
    public IActionResult Delete()
    {
        return View();
    }
}
