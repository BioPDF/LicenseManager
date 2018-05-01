using LicenseServerManager.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class ProductData
    {
        public string ActivationCode { get; set; }
        public string Version { get; set; }
    }

    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public HttpResponseMessage Post(string value)
        {
            //string xxx = request.Content.ReadAsStringAsync().Result;
            string keyHeader = "--pdf-printer-activation-key-begin--";
            string keyFooter = "--pdf-printer-activation-key-end--";

            string decodedValue = WebHelper.Base64Decode(value);
            decodedValue = decodedValue.Replace(keyHeader, "").Replace(keyFooter, "").Replace("\r", "").Replace("\n", "");
            decodedValue = WebHelper.Base64Decode(decodedValue);
            string[] parms = decodedValue.Split(';');

            string activationCode = parms[0];
            string machineName = parms[1];
            string version = parms[2];

            KeyValuePair<HttpStatusCode, string> result = WebHelper.PostData(activationCode, machineName, version);
            return Request.CreateResponse(result.Key, result.Value);

            //string data = "";
            //if (activationCode.Equals("BF214968-A5F3-4CA0-9B14-6D37F141028A"))
            //{
            //    data = "Thank you - your product has now been licensed";
            //    return Request.CreateResponse(HttpStatusCode.OK, data);
            //}
            //else
            //{
            //    data = "The activation key is not known in our database. Please provide a valide license key at try again.";
            //    return Request.CreateResponse(HttpStatusCode.InternalServerError, data);
            //}
            ////string encodedData = Base64Encode(data);
            ////return encodedData;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

    }
}
