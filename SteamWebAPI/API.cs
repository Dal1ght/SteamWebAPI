using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Specialized;
using System.Net.Http;
using System.Threading.Tasks;

namespace SteamWebAPI
{
    public class API
    {
		private static API _instance;

		internal static API Instance
		{
			get => _instance ?? throw CreateNotInitializedException();
			private set => _instance = value;
		}

		public static void Init(string APIKey, string language = "en_en")
		{
			Instance = new API(APIKey, language);
		}

		private static NullReferenceException CreateNotInitializedException()
		{
			return new NullReferenceException("API is not initialized. Use API.Init() method first.");
		}
		private readonly string APIKey;
		private readonly string language;
		private readonly HttpClient apiClient = new HttpClient() { BaseAddress = new Uri("http://api.steampowered.com/") };
		internal static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings()
		{
			MissingMemberHandling = MissingMemberHandling.Error
		};

		private API(string APIKey, string language = "en_en")
		{
			this.APIKey = APIKey;
			this.language = language;
		}

		public async Task<JObject> GetResponseAsync(string interfaceName, string methodName, int version = 1, NameValueCollection reqParams = null)
		{
			if (reqParams == null)
				reqParams = new NameValueCollection();
			reqParams["key"] = APIKey;
			reqParams["language"] = language;

			string query = $"{interfaceName}/{methodName}/v{version}?{reqParams}";
			var response = await apiClient.GetAsync(query);
			if (response.IsSuccessStatusCode)
			{
				return JObject.Parse(await response.Content.ReadAsStringAsync());
			}
			else
			{
				throw new Exception($"{response.StatusCode}: {response.ReasonPhrase}");
			}
		}
	}
}
