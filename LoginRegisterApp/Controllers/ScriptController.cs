using LoginRegisterApp.DbContext;
using LoginRegisterApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Drawing;

namespace LoginRegisterApp.Controllers
{
    public class ScriptController : Controller
    {
        private readonly ILogger<ScriptController> _logger;
        private readonly ScriptsContext _scriptsContext;
        private readonly CommentContext _commentContext;
        public ScriptController(ILogger<ScriptController> logger,ScriptsContext scriptsContext, CommentContext commentContext)
        {
            _logger = logger;
            _scriptsContext = scriptsContext;
            _commentContext = commentContext;
        }
        [HttpGet("ScriptPage/{ScriptId}")]
        public async Task<IActionResult> ScriptPage(int ScriptId)
        {
            try
            {
                _logger.Log(LogLevel.Information, $"ScriptPage {ScriptId} Ip Address is = {HttpContext.Request.Host}");
                var Script = await _scriptsContext.Script.FirstOrDefaultAsync(s => s.Id == ScriptId);
                var comment = _commentContext.comments.Where(c => c.Type == "Script" && c.TypeId == ScriptId);
                Image image = Image.FromStream(new MemoryStream(Script.ScriptImage));
                ViewBag["ScriptImage"] = image;
                var viewModel = new ScriptViewModel();
                viewModel.V_Scripts = Script;
                viewModel.V_Comments = comment.ToList();
                TempData["ScriptName"] = Script.ScriptName;
                return View(viewModel);
            }
            catch (Exception e)
            {
                _logger.Log(LogLevel.Error, $"ScriptPage {ScriptId} Ip Address is = {HttpContext.Request.Host} {e}");
                return RedirectToAction("Home","Home");
            }
        }
        [HttpPost]
        public async Task<IActionResult> ToolComment(Comments comment)
        {

            using (var commentContext = _commentContext)
            {
                comment.Type = "Script";
                await commentContext.comments.AddAsync(comment);
                int count = await commentContext.SaveChangesAsync();
                _logger.Log(LogLevel.Information, $"Comment Id {comment.Id} Ip Address is = {HttpContext.Request.Host}");
                if (count < 0)
                {
                    _logger.Log(LogLevel.Error, $"Comment Id  {comment.Id} Ip Address is = {HttpContext.Request.Host}");
                    return RedirectToAction("");
                }
            }
            return RedirectToAction("");
        }
    }
}
