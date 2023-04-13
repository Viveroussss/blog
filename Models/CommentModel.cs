using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace proj.Models
{
    public class CommentModel
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        public string CContent { get; set; }
        public PostModel Post { get; set; }
        public int PostId { get; set; }
        public bool CommentPosted { get; set; }
        public List<LikeModel> Likes { get; set; }
        public int LikesCount { get; set; }
        public ApplicationUser User { get; set; }
        public string? CommentAuthor { get; set; }
        public DateTime PostedOn { get; set; }
    }
}
