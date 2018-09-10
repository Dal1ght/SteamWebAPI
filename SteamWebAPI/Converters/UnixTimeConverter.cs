using Newtonsoft.Json;
using SteamWebAPI.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteamWebAPI.Converters
{
	public class UnixTimeConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			throw new NotImplementedException();
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.Value is long unixTime)
			{
				return DateTimeHelper.FromUnixTime(unixTime).ToLocalTime();
			}
			else
				throw new InvalidCastException($"{reader.ValueType.Name} {reader.Value} is not correct unix time");
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw new NotImplementedException();
		}
	}
}
