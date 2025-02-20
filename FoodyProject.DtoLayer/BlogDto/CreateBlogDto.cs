using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyProject.DtoLayer.BlogDto
{
    public class CreateBlogDto
    {
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogAuthor { get; set; }
        public DateTime BlogDate { get; set; }
        public string BlogImageUrl { get; set; }
    }
}
