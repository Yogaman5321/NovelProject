using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelProject.Models
{
    public class Tag
    {
        public int TagId { get; set; }

        public string TagName { get; set; }

        public string TagDescription { get; set; }

        public Tag(int tagId, string tagName, string tagDescription)
        {
            TagId = tagId;
            TagName = tagName;
            TagDescription = tagDescription;
        }

    }
}
