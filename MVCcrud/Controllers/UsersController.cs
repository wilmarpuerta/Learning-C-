using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCcrud.Data;

namespace MVCcrud.Controllers;

public class UsersController : Controller
{
    public readonly UserContext _context;

    public UsersController(UserContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Users.ToListAsync());
    }
}