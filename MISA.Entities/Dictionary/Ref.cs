using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MISA.Entities
{
    public class Ref
    {
        public Guid RefID { get; set; }
        public DateTime RefBirth { get; set; }
        public string RefNo { get; set; }
        public string RefPhone { get; set; }
        public string Note { get; set; }
        public string ContactName { get; set; }
        public string Status { get; set; }
        public string Group { get; set; }
    }
}