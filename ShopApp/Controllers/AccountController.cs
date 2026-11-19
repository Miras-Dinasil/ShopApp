using Microsoft.AspNetCore.Mvc;
using ShopApp.Models;

namespace ShopApp.Controllers;

public class AccountController : Controller
{
    // Форманы ашу үшін (GET)
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    // Форманы қабылдау және тексеру үшін (POST)
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Register(RegisterUserViewModel model)
    {
        // Серверлік валидация тексеруі
        if (!ModelState.IsValid)
        {
            return View(model); // Қателермен форманы қайта көрсету
        }

        // Қолмен қате қосу мысалы (бизнес-логика)
        if (model.Email.EndsWith("@test.com"))
        {
            ModelState.AddModelError(nameof(model.Email), "Бұл доменді пайдалануға болмайды");
            return View(model);
        }

        // Деректер қорына сақтау орны (қазірше тек сәттілік хабарламасын шығарамыз)
        TempData["Success"] = "Тіркелу сәтті өтті!";
        return RedirectToAction(nameof(Register));
    }
}