using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace proj.Models
{
    public class PostModel
    {
        
        public int Id { get; set; }
        
        public string? UserId { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Content { get; set; }

        public DateTime? CreatedAt { get; set; }

        public ApplicationUser? User { get; set; }
        public List<CommentModel> Comments { get; set; }
        public List<LikeModel> Likes { get; set; }
        public int LikesCount { get; set; }
    }
}
