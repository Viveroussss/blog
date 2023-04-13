namespace proj.Models
{
    public class LikeModel
    {
        public int Id { get; set; }
        public CommentModel Comment { get; set; }
        public int CommentId { get; set; }
        public PostModel Post { get; set; }
        public int PostId { get; set; }
        public string Username { get; set; }
        public ApplicationUser User { get; set; }
}
}
