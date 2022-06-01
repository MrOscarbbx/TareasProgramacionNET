using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Examen3.Models;
using Examen3.Data;
using Microsoft.EntityFrameworkCore;

namespace Examen3.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return _context.Categorias != null ?
                    View(await _context.Categorias.ToListAsync()) :
                    Problem("Entity set 'ApplicationDbContext.Categorias'  is null.");
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public async Task<IActionResult> Entradas()
    {
        return _context.Platillo != null ?
                    View(await _context.Platillo.ToListAsync()) :
                    Problem("Entity set 'ApplicationDbContext.Platillo'  is null.");
    }
    public async Task<IActionResult> Comidas()
    {
        return _context.Platillo != null ?
                    View(await _context.Platillo.ToListAsync()) :
                    Problem("Entity set 'ApplicationDbContext.Platillo'  is null.");
    }
    public async Task<IActionResult> Bebidas()
    {
        return _context.Platillo != null ?
                    View(await _context.Platillo.ToListAsync()) :
                    Problem("Entity set 'ApplicationDbContext.Platillo'  is null.");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
