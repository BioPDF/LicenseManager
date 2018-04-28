using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace LicenseServerManager.Helpers
{
    public static class WebHelper
    {
        public static KeyValuePair<HttpStatusCode, string> PostData(string activationKey, string machineName, string version)
        {
            try
            {
                string apiKey = "adf98da6fgd8a98fd7gads8fw";
                string urlString = $"http://www.biopdf.com/api/licensemanager/endpoint.php?fn=activate&apikey={apiKey}&activationkey={activationKey}&machinename={machineName}&version={version}";

                RestClient client = new RestClient(urlString);

                var request = new RestRequest(Method.GET);
                //request.Resource = "api/values?value=" + encodedData;
                //request.AddParameter("application/json", encodedData, ParameterType.RequestBody);
                //request.AddBody(encodedData);

                IRestResponse response = client.Execute(request);

                KeyValuePair<HttpStatusCode, string> result = new KeyValuePair<HttpStatusCode, string>(response.StatusCode, response.Content.ToString());
                return result;
                //if (response.StatusCode == HttpStatusCode.OK)
                //{
                //    // OK
                //    string result = response.Content.ToString();
                //    string decodedResult = result; // Base64Decode(result.Replace("\"", ""));
                //    return decodedResult;
                //}
                //else
                //{
                //    // Not OK
                //    return "response not ok";
                //}
            }
            catch (Exception ex)
            {
                return new KeyValuePair<HttpStatusCode, string>(HttpStatusCode.ServiceUnavailable, "The validation failed. Please contact us for help"); ;
            }

        }

    }
}