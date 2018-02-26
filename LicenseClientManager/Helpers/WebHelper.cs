using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using RestSharp;
using RestSharp.Deserializers;

namespace LicenseClientManager.Helpers
{
    static class WebHelper
    {
        static string url = "http://licman.codepower.biz";
        //static string url = "http://localhost:54925/";
        public static string PostData(string data)
        {
            try
            {
                string jsonToSend = "=" + GetData(data);
                string encodedData = Base64Encode(jsonToSend);

                RestClient client = new RestClient(url);

                var request = new RestRequest(Method.POST);
                request.Resource = "api/values?value=" + encodedData;
                request.AddParameter("application/json", encodedData, ParameterType.RequestBody);

                request.AddBody(encodedData);

                IRestResponse response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    // OK
                    string result =  response.Content.ToString();
                    string decodedResult = result; // Base64Decode(result.Replace("\"", ""));
                    return decodedResult;
                }
                else
                {
                    // Not OK
                    return "response not ok";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public static string TestEncoding(string text)
        {
            string encodedData = Base64Encode(text);
            string decodedData = Base64Decode(encodedData);
            return decodedData;
        }

        static string GetData(string activationCode)
        {
            Dictionary<string, string> ClientData = new Dictionary<string, string>
            {
                {"ActivationCode", activationCode },
                {"Version", "1.23"}
            };

            var result = Newtonsoft.Json.JsonConvert.SerializeObject(ClientData);

            return result;
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
