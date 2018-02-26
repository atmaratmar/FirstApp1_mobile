using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FirstApp1
{
    public class ArticleContentPage : ContentPage

    {
        private WebView _webView;
        public ArticleContentPage()
        {
            Content = _webView = new WebView();


        }
        public Model.Article Article { get; set; }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Title = Article.Title;
            _webView.Source = new UrlWebViewSource
            {
                 Url=Article.Articaleuser
            };
        }
    }
}
