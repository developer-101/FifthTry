using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace FifthTry
{
    public class MySearchHandler : SearchHandler
    {
        private List<string> names = new List<string>
        {
            "rustam",
            "zarina",
            "amir",
            "tagir",
            "jasmin"
        };

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = names.Where(i => i.ToLowerInvariant().Contains(newValue.ToLowerInvariant())).ToList();
            }
        }

        protected override void OnItemSelected(object item)
        {
            base.OnItemSelected(item);

            string selectedText = (string)item;
            AppShell.Current.DisplayAlert(null, selectedText, "Ok");
        }
    }
}
