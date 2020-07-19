using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbookWebsite.Models
{
    public class FileModel
    {
        public int Id { get; set; }
        public string FileExtention { get; set; }
        public int FileSize { get; set; }
        public byte[] File { get; set; }
    }
}
