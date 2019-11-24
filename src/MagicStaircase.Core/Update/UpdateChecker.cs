using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MagicStaircase.Core
{
    public class UpdateChecker
    {
        private readonly string currentVersion;

        public UpdateChecker()
        {
            currentVersion = Configuration.CurrentVersion();
        }

        public async Task<string> LastRelease()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("MagicS", ""));
                string endpoint = $"https://api.github.com/repos/Middlederg/MagicStaircase/releases/latest";
                HttpResponseMessage response = await client.GetAsync(endpoint);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Could not check if program is up to date\n{await response.Content.ReadAsStringAsync()}");
                }
                
                string json = await response.Content.ReadAsStringAsync();
                var version = JsonConvert.DeserializeObject<VersionViewModel>(json);
                return version.Tag_Name;
            }
        }

        public async Task<bool> IsUpToDate()
        {
            var lastRelease = await LastRelease();
            return currentVersion.Equals(lastRelease);
        }
    }
}
