using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parseJSONFile
{
	class JSONLoader
	{

		public static string readJSONLocalFile(String fullPath)
		{

			using (StreamReader sr = File.OpenText(fullPath))
			{
				string json = sr.ReadToEnd();
				return json;
			}

		}

	}
}
