using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace EbookWebsite.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public List<string> Authors { get; set; }
        public string Publisher { get; set; }
        public string Language { get; set; }
        public int Edition { get; set; }
        public int Pages { get; set; }
        public string Description { get; set; }
        public List<string> Tags { get; set; }
        public ImageModel MainImage { get; set; }
        public List<FileModel> Files{ get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<BookModel>(this);
        }
    }
}
