using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace SteamWebAPI.Helpers
{
	public static class Resources
	{
		public static JObject GetCountries()
		{
			var assembly = Assembly.GetExecutingAssembly();
			var resourceName = "SteamWebAPI.Resources.steam_countries.json";

			JObject countries = null;

			using (Stream stream = assembly.GetManifestResourceStream(resourceName))
			using (StreamReader reader = new StreamReader(stream))
			{
				string result = reader.ReadToEnd();
				countries = JObject.Parse(result);
			}

			return countries;
		}
	}
}
