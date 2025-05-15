using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using BlueWhatsapp.Api.models.VM;
using Microsoft.AspNetCore.Identity;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Api.Utils;
using BlueWhatsapp.Core.Services;
using BlueWhatsapp.Core.Models.Users;
using Microsoft.AspNetCore.Http;

public class BackofficeController : Controller
{
    private readonly IUserService _userService;
    private readonly IAppLogger _logger;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="userService"></param>
    /// <param name="logger"></param>
    public BackofficeController(IUserService userService, IAppLogger logger)
    {
        _logger = logger;
        _userService = userService;
    }

    /// <summary>
    /// Displays the Index page in the Backoffice section.
    /// </summary>
    /// <returns>Returns the Index view for the Backoffice section.</returns>
    [LogAction]
    public IActionResult Index()
    {
        string? userName = HttpContext.Session.GetString("UserName");
        if (!string.IsNullOrEmpty(userName))
        {
            return RedirectToAction("Dashboard");
        }

        return View();
    }

    /// <summary>
    /// Displays the Dashboard page in the Backoffice section.
    /// </summary>
    /// <returns>Returns the Dashboard view for the Backoffice section.</returns>
    [HttpPost]
    [LogAction]
    public async Task<ActionResult> Dashboard(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            CoreUser? user = await VerifyCredentials(model.Email, model.Password).ConfigureAwait(true);
            if (user != null)
            {
                HttpContext.Session.SetString("UserName", user.Name);
                HttpContext.Session.SetInt32("UserId", (int)user.Id);
                HttpContext.Session.SetString("UserEmail", user.Email);
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
    /// Displays the Dashboard page in the Backoffice section.
    /// </summary>
    /// <returns>Returns the Dashboard view.</returns>
    public IActionResult Dashboard()
    {
        // Retrieve user data from session
        string? userName = HttpContext.Session.GetString("UserName");
        if (string.IsNullOrEmpty(userName))
        {
            // If no user data is found, redirect to login
            return RedirectToAction("Index");
        }


        ViewBag.User = userName;
        ViewBag.AlpineComponent = "dashboard";
        ViewBag.ActivePage = "Dashboard";
        ViewBag.IsAdmin = IsUserAdmin();

        return View();
    }

    /// <summary>
    /// Displays the Trips page in the Backoffice section.
    /// </summary>
    /// <returns>Returns the Trips view.</returns>
    public IActionResult Trips()
    {
        ViewBag.IsAdmin = IsUserAdmin();
        return View();
    }

    /// <summary>
    /// Displays the Hotels page in the Backoffice section.
    /// </summary>
    /// <returns>Returns the Hotels view.</returns>
    public IActionResult Hotels()
    {
        ViewBag.IsAdmin = IsUserAdmin();

        return View();
    }

    /// <summary>
    /// Displays the Schedules page in the Backoffice section.
    /// </summary>
    /// <returns>Returns the Schedules view for the Backoffice section.</returns>
    public IActionResult Schedules()
    {
        ViewBag.IsAdmin = IsUserAdmin();

        return View();
    }

    /// <summary>
    /// Displays the reserves page for managing manual reservations and seeing existing ones.
    /// </summary>
    /// <returns>Returns a view that represents the reserves page.</returns>
    public IActionResult Reserves()
    {
        ViewBag.IsAdmin = IsUserAdmin();

        return View();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public IActionResult Referals()
    {
        ViewBag.IsAdmin = IsUserAdmin();

        return View();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public IActionResult Users()
    {
        ViewBag.IsAdmin = IsUserAdmin();

        return View();
    }


    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public IActionResult Routes()
    {
        ViewBag.IsAdmin = IsUserAdmin();

        return View();
    }

    /// <summary>
    /// Logs out the current user and redirects to the Index page of the Backoffice controller.
    /// </summary>
    /// <returns>Redirects to the Index page of the Backoffice controller.</returns>
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index", "Backoffice");
    }

    /// <summary>
    /// Verifies the provided user credentials against the authentication system.
    /// </summary>
    /// <param name="email">The email address of the user attempting to log in.</param>
    /// <param name="password">The password associated with the specified email address.</param>
    /// <returns>Returns true if the credentials are valid; otherwise false.</returns>
    private async Task<CoreUser?> VerifyCredentials(string email, string password)
    {
        _logger.LogInfo($"Login attempt for {email}");
        CoreUser? user = await _userService.Login(email, password).ConfigureAwait(true);
        _logger.LogInfo($"Found user for {email}");

        return user;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private bool IsUserAdmin()
    {
        var adminIds = new List<int>() { 1, 2 };

        int? userId = HttpContext.Session.GetInt32("UserId");

        return adminIds.Contains((int)userId!);
    }
}