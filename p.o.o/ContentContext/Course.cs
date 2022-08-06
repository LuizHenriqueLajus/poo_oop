using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p.o.o.ContentContext
{
    public class Course : Content
    {
        public Course()
        {
            Modules = new List<Module>();
        }

        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
    }
}
