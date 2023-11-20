using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mgeditor.models
{
    public class Project
    {
        public string? ProjectName { get; set; }
        public Folder? RootFolder { get; set; }
    }
}
