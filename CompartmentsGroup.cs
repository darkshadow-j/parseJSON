using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parseJSONFile
{

    public enum COLOR {
        greenyellow,
        yellow,
        red,
        green,
        blue,
        orange
    }

	class CompartmentsGroup
	{
        public string typename { get; set; }
        public string type { get; set; }
        public COLOR color { get; set; }
        public int p1 { get; set; }
        public double p2 { get; set; }
        public int p3 { get; set; }
        public int p4 { get; set; }
        public int p5 { get; set; }
        public int p6 { get; set; }
        public int p7 { get; set; }
        public int p8 { get; set; }
    }
}
