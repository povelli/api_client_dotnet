using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Security.Cryptography;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Net.Http;
using System.Net;

namespace PovelliProductUpdate
{
    [DataContract]
    class PovelliProduct
    {
        [DataMember]
        public int store_id;
        [DataMember]
        public string code;
        [DataMember]
        public string name;
        [DataMember]
        public string family;
        [DataMember]
        public string size;
        [DataMember]
        public string manufacturer;
        [DataMember]
        public double price;
    }

    [DataContract]
    class PovelliResponse
    {
        [DataMember]
        public bool success;
        [DataMember]
        public int processed_items;
        [DataMember]
        public int not_processed_items;
        [DataMember]
        public string[] errors;
    }

    class PovelliAPIHelper
    {
        const string DEFAULT_API_DOMAIN = "dev.povelli.com";
        const string PRODUCT_UPDATE_API = "/e/agent/products/update";

        protected string getSignature(string publicKey, string privateKey, string method, string path, string timestamp)
        {
            string[] textArr = { publicKey, timestamp, method, path };
            string text = String.Join("\n", textArr);
            var hmac = new HMACSHA256(Encoding.ASCII.GetBytes(privateKey));
            var hash = hmac.ComputeHash(Encoding.ASCII.GetBytes(text));
            return Convert.ToBase64String(hash);
        }

        protected byte [] productsToJson(PovelliProduct [] products) {
            DataContractJsonSerializer jsonSer = new DataContractJsonSerializer(typeof(PovelliProduct[]));
            MemoryStream ms = new MemoryStream();
            jsonSer.WriteObject(ms, products);
            //string json = Encoding.UTF8.GetString(ms.ToArray());
            return ms.ToArray();
        }

        protected PovelliResponse sendRequest(string domain, string path, 
            string publicKey, string privateKey, byte[] payload)
        {
            HttpWebRequest request = HttpWebRequest.Create("https://" + domain + path) as HttpWebRequest;

            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            string timestamp =  (DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds.ToString();
            request.Headers.Add("PV-Signature: " + this.getSignature(publicKey, privateKey, request.Method, path, timestamp));
            request.Headers.Add("PV-Timestamp: " + timestamp);
            request.Headers.Add("PV-Public-Key: " + publicKey);
            request.UserAgent = ".NET-requests";

            request.ContentLength = payload.Length;
            request.GetRequestStream().Write(payload, 0, payload.Length);

            PovelliResponse res;
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception(String.Format("Server Error {0}", response.StatusCode));
                DataContractJsonSerializer jsonSer = new DataContractJsonSerializer(typeof(PovelliResponse));
                res = jsonSer.ReadObject(response.GetResponseStream()) as PovelliResponse;
            }

            return res;
        }

        public PovelliResponse sendProductUpdates(string publicKey, string privateKey, PovelliProduct [] products)
        {
            PovelliResponse res = this.sendRequest(
                PovelliAPIHelper.DEFAULT_API_DOMAIN, PovelliAPIHelper.PRODUCT_UPDATE_API,
                publicKey, privateKey, this.productsToJson(products));
            return res;
        }
    }
}
