using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace QueryingResourceHealthAzure
{
    public static class SubscriptionHelper
    {
        // Complete this information with your details ------------------------
        const string tenantId = "";
        const string appId = "";
        const string appKey = "";
        const string subscriptionId = "";
        // --------------------------------------------------------------------

        const string aadInstance = "https://login.microsoftonline.com/{0}";

        private static string resourceHealthFullUrl = string.Format("https://management.azure.com/subscriptions/{0}/providers/Microsoft.ResourceHealth/availabilityStatuses?api-version=2015-01-01", subscriptionId);
        private static string registerResourceHealthUrl = string.Format("https://management.azure.com/subscriptions/{0}/providers/Microsoft.ResourceHealth/register?api-version=2015-01-01", subscriptionId);

        public static async Task<string> GetSubscriptionResources()
        {
            var authenticationToken = await AuthenticationHelper.AcquireTokenBySPN(tenantId, appId, appKey);

            using (var httpClient = new HttpClient())
            {
                // Add the access token to the authorization header of the request.
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authenticationToken);

                // Retrieve information
                Console.WriteLine("Retrieving resources for subscription...");

                HttpResponseMessage response = await httpClient.GetAsync(resourceHealthFullUrl);

                if (response.IsSuccessStatusCode == true)
                {
                    Console.WriteLine("Resources successfully retrieved!");

                }
                else
                {
                    Console.WriteLine("Failed to retrieve list of resources:  {0}\n", response.ReasonPhrase);
                }

                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
