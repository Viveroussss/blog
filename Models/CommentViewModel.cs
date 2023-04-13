using Microsoft.Extensions.Hosting;

namespace proj.Models
{
    public class CommentViewModel
    {
        public PostModel Post { get; set; }
        public List<PostModel> Posts { get; set; }
        public List<CommentModel> Comments { get; set; }
    }
}
