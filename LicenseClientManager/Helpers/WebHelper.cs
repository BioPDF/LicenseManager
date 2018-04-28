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
        static string url = "";
        //static string url = "http://localhost:54925/";
        public static string PostData(string activationKey, string version, string machinename, string urlString)
        {
            try
            {
                //string jsonToSend = "=" + GetData(activationKey, version, machinename);
                string dataToSend = GetActivationKey(activationKey, version, machinename);
                string encodedData = Base64Encode(dataToSend);
                url = $"{urlString}";

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

        static string GetData(string activationCode, string version, string machineName)
        {
            Dictionary<string, string> ClientData = new Dictionary<string, string>
            {
                {"ActivationCode", activationCode},
                {"MachineName", machineName},
                {"Version", version}
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

        public static string GetActivationKey(string activationCode, string machineName, string version)
        {
            string keyHeader = "--pdf-printer-activation-key-begin--";
            string keyFooter = "--pdf-printer-activation-key-end--";
            string base64Key = "";
            string filler = "{35A7F82B-7DB4-48B7-AC57-A28CB4C5BDFD}{CB5306EF-9FB1-4F85-8037-EDDB3B6AEDFA}{AA03A518-E19F-4DE8-AEF7-6D04E4A909A3}";
            try
            {
                keyHeader = "--pdf-printer-activation-key-begin--";
                keyFooter = "--pdf-printer-activation-key-end--";
                base64Key = GetBase64Key(activationCode, machineName, version, filler);

                //--pdf-printer-activation-key-begin--
                //"Q+Dn9hnyntzCnrWfWZekzQzrpeb7z7iJWZekscufWZfA8g/jWev9ARC8W7zT"
                //"v+7nq+bx9s2fr9z2BBTup7SmwuKtaZmkwOmMQ5ekscu7aNjw/Rr2d4SOscuf"
                //"WbPzAw/kq8Dy9xqfndj49uihbKa5wN2vaqumsR70m7z8ARTxnurFBeihbKa5"
                //"wN2vaq6msSHkq+rtABm8W6mmsdq9RoGkscufdert+Bngrez29unDn6fKAfzP"
                //"jM3s5gHIkuPM1g3Aa6bVzui7aOrt+Bngrez29umMQ7Oz/RTinuX39umMQ3Xj"
                //"7fQQ7azcwp61n1mXpM0X6Jzc8gQQyJ21ucrjsnGvusndsHWm8PoO5Kfq6doP"
                //"vUaBpLHLn3Xj7fQQ7azc6c/nrqU="
                //--pdf-printer-activation-key-end--

            }
            catch (Exception)
            {
                throw;
            }
            return keyHeader + Environment.NewLine + base64Key + keyFooter;
        }

        private static string GetBase64Key(string activationCode, string machineName, string version, string filler)
        {
            string base64Key = WebHelper.Base64Encode($"{activationCode};{machineName};{version};{filler}");
            string base64KeyFormatted = FormatKeyString(base64Key, 60);
            return base64KeyFormatted;
        }

        private static string FormatKeyString(string base64Key, int chunkSize)
        {
            IEnumerable<string> chunks = Enumerable.Range(0, base64Key.Length / chunkSize)
                    .Select(i => base64Key.Substring(i * chunkSize, chunkSize));

            string formattedKey = "";
            foreach (string item in chunks)
            {
                formattedKey += item + Environment.NewLine;
            }

            return formattedKey;
        }

    }
}
