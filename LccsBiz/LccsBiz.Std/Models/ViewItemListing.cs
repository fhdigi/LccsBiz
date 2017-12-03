using System;
using System.Collections.Generic;
using System.Text;

namespace LccsBiz.Std.Models
{
    public class ViewItemListing
    {
        public string ImageSource { get; set; }
        public string HeadingTitle { get; set; }
        public string SubTitle { get; set; }

        public ViewItemListing(string imageFileName, string title, string subtitle)
        {
            ImageSource = imageFileName;
            HeadingTitle = title;
            SubTitle = subtitle;
        }
    }
}
