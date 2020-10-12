using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace parseJSONFile
{
	class Program
	{
		private static string FULL_PATH_JSON_FILE = "C:\\Users\\Pawel\\Desktop\\panel.json";
		static void Main(string[] args)
		{

			new Panel(JSONLoader.readJSONLocalFile(FULL_PATH_JSON_FILE));

			Thread.Sleep(5000);
		}
	}
}
