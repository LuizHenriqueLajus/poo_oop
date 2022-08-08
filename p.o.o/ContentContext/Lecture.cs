using p.o.o.ContentContext.Enums;
using p.o.o.SharedContext;

namespace p.o.o.ContentContext
{
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}
