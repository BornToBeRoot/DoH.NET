using System.Collections.Generic;

namespace DoH.NET
{
    public class Response
    {
        public int Status { get; set; }
        public bool TC { get; set; }
        public bool RD { get; set; }
        public bool RA { get; set; }
        public bool AD { get; set; }
        public bool CD { get; set; }
        public IList<Question> Question { get; set; }
        public IList<Answer> Answer { get; set; }
    }
}
