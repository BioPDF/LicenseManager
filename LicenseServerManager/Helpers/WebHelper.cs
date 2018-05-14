using Newtonsoft.Json.Linq;
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
                string urlString = $"http://www.biopdf.com/api/licensemanager/endpoint.php";

                JObject obj = new JObject(
                    new JProperty("activationkey", activationKey),
                    new JProperty("machine", machineName) //,
                    //new JProperty("version", version)
                );
                string encodedData = Base64Encode(obj.ToString());

                RestClient client = new RestClient(urlString);

                var request = new RestRequest(Method.POST);

                request.AddParameter("application/x-www-form-urlencoded", $"fn=activate&apikey={apiKey}&data={encodedData}", ParameterType.RequestBody);

                request.AddBody(encodedData);

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

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

    }
}