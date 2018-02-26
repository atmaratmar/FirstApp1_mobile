using FirstApp1.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FirstApp1
{
   public class ArticlesView :ContentPage
    {
        public ArticlesView()
        {
            Title = "EAL Mobile";
            var listView = new ListView();
            var textCell = new DataTemplate(typeof(TextCell));
            textCell.SetBinding(TextCell.TextProperty, "Title");
            textCell.SetBinding(TextCell.DetailProperty, "Autor");
            listView.ItemTemplate = textCell;
            listView.ItemsSource = DataServices.GetArticle();
            listView.ItemSelected += ListView_ItemSlected;
            Content = listView;
        }

        private void ListView_ItemSlected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;
            var page = new ArticleContentPage
            {
                Article = e.SelectedItem as Article
            };
            Navigation.PushAsync(page, true);
            var listView = sender as ListView;
            listView.SelectedItem = null;
        }
    }
}
