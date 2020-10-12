using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parseJSONFile
{

	public enum TYPES
	{
		C1,
		C2,
		C3,
		C4,
		C5,
		C6
	}

	class Compartment
	{
		public int id { get; set; }
		public TYPES type { get; set; }
	}
}
