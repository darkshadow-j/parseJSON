using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace parseJSONFile
{
	class Panel
	{
		public string panelName { get; set; }
		public double controlOffset { get; set; }
		public List<CompartmentsGroup> compartmentsGroup { get; set; }
		public List<Compartment> compartments { get; set; }

		public Panel(string json)
		{
			JObject jObject = JObject.Parse(json);
			panelName = jObject["panelName"].ToString();
			controlOffset = Double.Parse(jObject["controlOffset"].ToString());
			JArray compartmentsGroups = (JArray)jObject["compartmentsGroup"];
			JArray compartmentsList = (JArray)jObject["compartments"];
			compartments = compartmentsList.ToObject<List<Compartment>>();
			compartmentsGroup = compartmentsGroups.ToObject<List<CompartmentsGroup>>();
			Console.WriteLine(compartmentsGroup[0].color);

		}

	}
}
