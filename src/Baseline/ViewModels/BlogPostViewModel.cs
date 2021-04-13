using Baseline.Models;
using System.Collections.Generic;

namespace Baseline.ViewModels
{
    public class BlogPostViewModel
    {
        public Models.BlogPost blogPost { get; set; }
        public List<CommentViewModel> comments { get; set; }
        public Models.User user { get; set; }
    }

    public class CommentViewModel
    {
        public Comment comment { get; set; }
        public string authorName { get; set; }
    }
}
