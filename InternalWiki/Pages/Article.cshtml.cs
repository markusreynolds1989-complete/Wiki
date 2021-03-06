using System;
using System.Linq;
using System.Text;
using InternalWiki.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InternalWiki.Pages
{
    public class ArticleModel : PageModel
    {
        public void OnGet(int id)
        {
            var article = ArticleController.ArticleList[id];
            ViewData["id"] = id;
            ViewData["title"] = article.Title;
            ViewData["content"] = article.Content;
            ViewData["tags"] = article.Tags;
        }
    }
}