using System.Drawing;
using LoginRegisterApp.DbContext;
using LoginRegisterApp.Models;
using LoginRegisterApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoginRegisterApp.Controllers
{
    public class ToolsController : Controller
    {
        private readonly ToolsContext _toolsContext;
        private readonly IFormService _formService;
        private readonly CommentContext _commentContext;
        public ToolsController(ToolsContext toolsContext, IFormService formService, CommentContext commentContext)
        {
            _toolsContext = toolsContext;
            _formService = formService;
            _commentContext = commentContext;
        }
        [HttpGet("ToolPage/{ToolName}")] //asp-route-ToolName ile gelen değişken karşılanıyor
        public async Task<IActionResult> ToolPage(string ToolName) // Karşılanan değişken method parametresine aktarılıyor
        {
            var Tool = await _toolsContext.tools.FirstOrDefaultAsync(t => t.ToolName == ToolName); //method parametresi kullanılarak Tool referansı sorgulanıp bulunuyor
            Image image = Image.FromStream(new MemoryStream(Tool.ToolImage)); // Tool resmi için örnek oluşturuluyor
            ViewBag["ToolImage"] = image; //ViewBag ile resim örneği sayfaya aktarılıyor
            var Comment = _commentContext.comments.Where(c => c.Type == "Tool" && c.TypeId == Tool.Id); //Comment örnekleri oluşturuluyor
            var ViewModel = new ToolViewModel(); // viewmodel referansı oluşturuluyor
            ViewModel.tools = Tool; // ViewModel dolduruluyor
            ViewModel.comments = Comment.ToList(); //ViewModel Dolduruluyor
            TempData["ToolName"] = ToolName; //temp data ile Tool name aktarılıyor
            return View(ViewModel); // ViewModel return ediliyor
        }

        [HttpPost]
        public async Task<IActionResult> ToolComment(Comments comment)
        {
            using(var commentContext = _commentContext)
            {
                comment.Type = "Tool";
                await commentContext.comments.AddAsync(comment);
                int count = await commentContext.SaveChangesAsync();
                if (count < 0)
                {
                    return RedirectToAction("");
                }
            }
            return RedirectToAction("");
        }
    }
}