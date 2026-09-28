using System;
using System.Collections.Generic;
using System.Text;

namespace NameCore
{
    public class Nevnap
    {
    
        public Nevnap(DateTime dates, string names)
        {
            Dates = dates;
            Names = names;
        }
        public DateTime Dates { get; set; }

        public string Names { get; set; }
    
    }
}
