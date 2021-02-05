using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEO_Analyzer
{
    public class SEOKeyWord
    {
        public string Keyword { get; set; }
        public int NumClicks { get; set; }
        public int NumImpressions { get; set; }
        public decimal ClickThroughRate { get; set; }
        public decimal AveragePosition { get; set; }
        
    }
}
