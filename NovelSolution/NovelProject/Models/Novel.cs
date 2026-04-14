using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelProject.Models
{
    public class Novel
    {
        public int NovelId { get; set; }

        public int UploadedByUserId { get; set; }

        public string AuthorName { get; set; }
        public string NovelName { get; set; }
        public string Description { get; set; }
        public DateTime DatePosted { get; set; }

        // Maybe add a DateEdited property? 
    }
}
