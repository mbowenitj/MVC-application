using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MV.Models
{
    public class Jobs
    {
        public string Client { get; set; }
        public int Job_Number { get; set; }
        public string Job_Name { get; set; }
        public DateTime Due { get; set; }
        public string Status { get; set; }
    }
}