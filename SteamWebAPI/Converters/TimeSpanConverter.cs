using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteamWebAPI.Converters
{
	public class TimeSpanConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			throw new NotImplementedException();
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.Value is long value)
				return TimeSpan.FromSeconds(value);
			else throw new InvalidCastException($"Can not convert {reader.ValueType.Name} {reader.Value} to TimeSpan");
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw new NotImplementedException();
		}
	}
}
