using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace com.andymerhaut.api_demo {
    class Program {
        static void Main(string[] args) {

            //Get 100 doctors from BayCare's REST API
            var url = "https://api.baycare.org/api/Provider?resultsperpage=100";
            var providers = GetProviders(url);

            SaveProviders(providers);
        }

        /// <summary>
        /// Create a Web client to execute REST call
        /// </summary>
        /// <param name="url">string. the location of the /GET resource</param>
        /// <returns>Provider[]. An array of deserialized Provider records.</returns>
        private static Provider[] GetProviders(string url) {

            using (var client = new WebClient())
            {
                var response = client.DownloadString(new Uri(url));
                return JsonConvert.DeserializeObject<Provider[]>(response);
            }
        }

        /// <summary>
        /// Saves providers to local database.
        /// </summary>
        /// <param name="providers"></param>
        private static void SaveProviders(Provider[] providers)
        {
            using (var db = new Model1())
            {
                foreach (var provider in providers)
                {
                    if (!db.Providers.Any(p => p.ProviderId == provider.ProviderId))
                        db.Providers.Add(provider); //Add if provider does not already exist
                }
                db.SaveChanges();
            }
        }
    }
}
