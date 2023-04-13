using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;

namespace proj.Models
{
    public class ApplicationUser :IdentityUser
    {
        public IEnumerable<PostModel> Posts { get; set; }
        public List<CommentModel> Comments { get; set; }
        public List<LikeModel> Likes { get; set; }
      ///  public byte[] ProfilePicture { get; set; }
    }
}
