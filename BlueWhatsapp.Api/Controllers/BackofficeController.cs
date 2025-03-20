using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using BlueWhatsapp.Api.models.VM;
using Microsoft.AspNetCore.Identity;
namespace BlueWhatsapp.Api.Controllers;

public class BackofficeController : Controller
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Dashboard(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            bool isAuthenticated = VerifyCredentials(model.Email, model.Password);
            
            if (isAuthenticated)
            {
                return RedirectToAction("Dashboard", "Backoffice");
            }
            else
            {
                ModelState.AddModelError("", "Invalid email or password.");
            }
        }
        
        return View("Index", model);
    }

    
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public IActionResult Dashboard()
    {
        return View();
    }
    
    private bool VerifyCredentials(string email, string password)
    {
        // Implement your authentication logic here
        // This might involve checking against a database, etc.
        return true; // Placeholder
    }
}