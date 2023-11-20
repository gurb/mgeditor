using mgeditor.models.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mgeditor.models
{
    public class File
    {
        public FileType FileType { get; set; }
        public string? Name { get; set; }
        public Folder? ParentFolder { get; set; }
        public string? Data { get; set; }
        public string? TabGuid { get; set; }
    }
}
