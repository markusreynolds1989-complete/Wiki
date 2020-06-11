﻿using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Html;
using Microsoft.CodeAnalysis.CSharp;
using Newtonsoft.Json;
using JsonConverter = System.Text.Json.Serialization.JsonConverter;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace InternalWiki.Data

{
    public static class ArticleController
    {
        public static readonly Dictionary<int, Article> ArticleList = new Dictionary<int, Article>();

        private const string ArticlePath =
            @"C:\Users\MR071411\Desktop\FunCode\CSharp\Wiki\InternalWiki\Pages\Articles";

        private const string ArticleJsonPath =
            @"C:\Users\MR071411\Desktop\FunCode\CSharp\Wiki\InternalWiki\Pages\Articles\articles.json";

        private static void ReadJsonArticle()
        {
            using var r = new StreamReader(File.ReadAllText(ArticleJsonPath));
            var json = r.ReadToEnd();
            var articles = JsonConvert.DeserializeObject<List<Article>>(json);
        }

        public static void WriteJsonArticle(Article article)
        {
            var serialized = JsonSerializer.Serialize(article);
            File.AppendAllText(ArticleJsonPath,serialized);
        }
        
        private static void AddToArticleList(int id, Article article) =>
            ArticleList.Add(id, article);


        // Increment the articleID.
        private static int IncArticleId() =>
            ArticleList.Keys.Last() + 1;

        // Run on start up to get a dictionary of all the articles we already have and give them an ID.
        public static void FillArticleList()
        {
            var count = 0;
            foreach (var article in Directory.EnumerateFiles(ArticlePath))
            {
                ArticleList.Add(count++, new Article(File.ReadAllLines(article).ToList()));
            }
        }

        // Write article object into a text file.
        public static bool WriteArticle(string title, string content, string tags)
        {
            var article = new Article(title, content, tags);
            File.WriteAllText(article.Path, article.FormatArticle());
            AddToArticleList(IncArticleId(), article);
            return File.Exists(article.Path);
        }

        // Same as writing except don't add it to the list.
        public static bool ModifyArticle(Article article)
        {
            File.WriteAllText(article.Path, article.FormatArticle());
            return File.Exists(article.Path);
        }

        // Update the file when it's called, there may have been changes from the original read.
        public static Article ReadArticle(int id)
        {
            var article = ArticleList[id];
            return new Article(File.ReadAllLines(article.Path).ToList());
        }
    }
}