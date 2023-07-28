using LoginRegisterApp.DbContext;
using LoginRegisterApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace LoginRegisterApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ShowcaseContext _showcaseContext;
        private readonly ScriptsContext _scriptsContext;
        private readonly ToolsContext _toolsContext;
        public HomeController(ILogger<HomeController> logger , ShowcaseContext showcaseContext, ScriptsContext scriptsContext, ToolsContext toolsContext)
        {
            _logger = logger;
            _showcaseContext = showcaseContext;
            _scriptsContext = scriptsContext;
            _toolsContext = toolsContext;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Home()
        {
            _logger.LogInformation("Reached Homepage");
            var showcases = await _showcaseContext.showcases.ToListAsync();
            if (showcases is null)
            {
                return NotFound();
            }
            return View(showcases);
        }
        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }
        [AllowAnonymous]

        public async Task<IActionResult> Scripts()
        {
            _logger.LogInformation("Reached Scripts Page");
            var Scripts = await _scriptsContext.Script.ToListAsync();
            if (Scripts is null)
            {
                return NotFound();
            }
            return View(Scripts);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Tools()
        {
            _logger.LogInformation("Reached Homepage");
            var tools = await _toolsContext.tools.ToListAsync();
            if (tools is null)
            {
                return NotFound();
            }
            return View(tools);
        }
        [AllowAnonymous]
        public IActionResult Questions()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult About()
        {
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}