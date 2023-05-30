using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebBlogMVC.Models
{
    public class PostsFiltrModel
    {
        public IEnumerable<Post> Posts { get; set; } = new List<Post>();
        public SelectList Categories { get; set; } = new SelectList(new List<Category>(), "Id", "Title");

    }
}
