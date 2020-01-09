using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace finalproject.MarkupExtension
{
    [ContentProperty(nameof(Source))]
    public class ImageSourceExtension:IMarkupExtension
    {
        public string Source { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Source == null ? null : ImageSource.FromResource(Source);
        }
    }
}
