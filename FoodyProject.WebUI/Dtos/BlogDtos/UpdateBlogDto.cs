namespace FoodyProject.WebUI.Dtos.BlogDtos
{
    public class UpdateBlogDto
    {
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogAuthor { get; set; }
        public DateTime BlogDate { get; set; }
        public string BlogImageUrl { get; set; }
    }
}
