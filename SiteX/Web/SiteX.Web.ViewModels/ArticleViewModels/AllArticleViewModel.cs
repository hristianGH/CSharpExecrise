﻿namespace SiteX.Web.ViewModels.ArticleViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using SiteX.Data.Models.Article;

    public class AllArticleViewModel : PagingViewModel
    {
        public ICollection<Article> Articles { get; set; } = new List<Article>();
    }
}
