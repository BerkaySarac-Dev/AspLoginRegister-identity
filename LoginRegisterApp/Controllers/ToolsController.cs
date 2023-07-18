using System.Drawing;
using LoginRegisterApp.DbContext;
using LoginRegisterApp.Models;
using LoginRegisterApp.Services;
using Microsoft.AspNetCore.Mvc;

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
        [HttpGet("ToolPage/{ToolName}")]
        public IActionResult ToolPage(string ToolName)
        {
            var Tool = _toolsContext.tools.Where(t => t.ToolUrl == ToolName).FirstOrDefault();
            Image image = Image.FromStream(new MemoryStream(Tool.ToolImage)); //! ViewModel oluşturulacak Comments ve Tools beraber view içine aktarılacak
            ViewBag["ToolImage"] = image;
            var Comment = _commentContext.comments.Where(c => c.Type == "Tool" && c.TypeId == Tool.Id).FirstOrDefault();
            var ViewModel = new ToolViewModel();
            ViewModel.tools = Tool;
            ViewModel.comments = Comment;
            TempData["ToolName"] = ToolName;

            return View(ViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> ToolComment(Comments comment)
        {
            using(var commentContext = _commentContext)
            {
                await commentContext.comments.AddAsync(comment);
                int count = await commentContext.SaveChangesAsync();
                if (count < 0)
                {
                    return RedirectToAction("ToolPage","Tools");
                }
            }
            return RedirectToAction("ToolPage", "Tools");
        }
    }
}