﻿using PostureApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PostureApp.Views
{
    public partial class PostureMovementLibrary : ContentPage
    {
        public PostureMovementLibrary()
        {
            InitializeComponent();
        }
        SelectMultipleBasePage<CheckItem> multiPage;

       

        async void sss()
        {
            var items = new List<CheckItem>();
            items.Add(new CheckItem { Name = "Xamarin.com" });
            items.Add(new CheckItem { Name = "Twitter" });
            items.Add(new CheckItem { Name = "Facebook" });
            items.Add(new CheckItem { Name = "Internet ad" });
            items.Add(new CheckItem { Name = "Online article" });
            items.Add(new CheckItem { Name = "Magazine ad" });
            items.Add(new CheckItem { Name = "Friends" });
            items.Add(new CheckItem { Name = "At work" });

            if (multiPage == null)
                multiPage = new SelectMultipleBasePage<CheckItem>(items) { Title = "Check all that apply" };

            await Navigation.PushAsync(multiPage);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (multiPage != null)
            {
                results.Text = "";
                var answers = multiPage.GetSelection();
                foreach (var a in answers)
                {
                    results.Text += a.Name + ", ";
                }
            }
            else
            {
                results.Text = "(none)";
            }
        }
    }
}
