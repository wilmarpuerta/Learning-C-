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

    public async Task<IActionResult> Show(int? id)
    {
        return View(await _context.Users.FirstOrDefaultAsync(m => m.Id == id));
    }
   
    public IActionResult Delete()
        {
            return View();
        }
    
    public IActionResult Update()
        {
            return View();
        }
}