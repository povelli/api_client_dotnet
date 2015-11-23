using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Net;

namespace Povelli
{
    /// <summary>
    /// This library is a wrapper to enable communication between your application and Povelli service.
    /// 
    /// --- DO NOT MODIFY THIS FILE ---
    /// 
    /// Using this file as-is and unmodified will greately help ease upgrading to future releases provided
    /// by Povelli team and allows for dropping the new version of this file in place without having to 
    /// worry about manually merging changes.
    /// </summary>

    [DataContract]
    class PovelliStore
    {
        [DataMember]
        public string store_uid = "";
    }

    [DataContract]
    class PovelliProductFilter : PovelliStore
    {
        [DataMember]
        public string upc = "";
        [DataMember]
        public string size = "";

        public PovelliProductFilter(string store_uid, string upc, string size)
        {
            this.store_uid = store_uid;
            this.upc = upc;
            this.size = size;
        }
    }

    [DataContract]
    class PovelliLabelFilter : PovelliStore
    {
        [DataMember]
        public string label_barcode = "";

        public PovelliLabelFilter(string store_uid, string label_barcode)
        {
            this.store_uid = store_uid;
            this.label_barcode = label_barcode;
        }
    }

    [DataContract]
    class PovelliProduct : PovelliProductFilter
    {
        [DataMember]
        public string name = "";
        [DataMember]
        public string family = "";
        [DataMember]
        public string manufacturer = "";
        [DataMember]
        public double price = 0.0;

        public PovelliProduct(string store_uid, string upc, string size) : base(store_uid, upc, size)
        {
        }

        public override string ToString()
        {
            return name;
        }
    }

    [DataContract]
    class PovelliProductStatus : PovelliProductFilter
    {
        [DataMember]
        public PovelliLabel[] labels = null;

        public PovelliProductStatus(string store_uid, string upc, string size) : base(store_uid, upc, size)
        {
        }
    }

    [DataContract]
    class PovelliLabel
    {
        [DataMember]
        public string label_barcode = "";
        [DataMember]
        public string status = "";
        [DataMember]
        public double battery_level = 0;
        [DataMember]
        public double signal_level = 0;
        [DataMember]
        public string model = "";
        [DataMember]
        public string size = "";
        [DataMember]
        public string template_name = "";
        [DataMember]
        public string template_uid = "";
        [DataMember]
        public string last_upate = "";

        [DataMember]
        public PovelliTemplate[] available_templates = null;

        public override string ToString()
        {
            return label_barcode + (template_name!=""? " ("+template_name+")" : "");
        }
    }

    [DataContract]
    class PovelliTemplate
    {
        [DataMember]
        public string name = "";
        [DataMember]
        public string uid = "";
        [DataMember]
        public string preview_url = "";
        [DataMember]
        public string last_assigned = "";
        [DataMember]
        public string last_updated = "";

        public override string ToString()
        {
            return name;
        }
    }

    [DataContract]
    class PovelliLabelAssignment : PovelliLabelFilter
    {
        [DataMember]
        public string product_upc = "";
        [DataMember]
        public string product_size = "";
        [DataMember]
        public string template_uid = "";

        public PovelliLabelAssignment(string store_uid, string label_barcode, string product_upc, string product_size, 
            string template_uid) : base(store_uid, label_barcode)
        {
            this.product_upc = product_upc;
            this.product_size = product_size;
            this.template_uid = template_uid;
        }
    }

    [DataContract]
    class PovelliResponse
    {
        [DataMember]
        public bool success = true;
        [DataMember]
        public int processed_items = 0;
        [DataMember]
        public int not_processed_items = 0;
        [DataMember]
        public PovelliErrorItem[] errors = null;
        [DataMember]
        public PovelliProductStatus[] products = null;
        [DataMember]
        public PovelliLabel[] labels = null;

        public override string ToString()
        {
            string str = "";
            if (success)
            {
                str = "API Call Succeeded.";
            }
            else
            {
                str = "API Call Failed: ";

                if (errors.Length > 0)
                {
                    for (int i = 0; i < errors.Length; i++) str += errors[i].error + " ";
                }
            }
            return str;
        }
    }

    [DataContract]
    class PovelliErrorItem
    {
        [DataMember]
        public string obj = "";
        [DataMember]
        public string error = "";
    }

    class PovelliAPI
    {
        const string DEFAULT_API_DOMAIN = "dev.povelli.com";

        const string API_URL_PRODUCTS_UPDATE = "/e/backoffice/products/update";
        const string API_URL_PRODUCTS_DELETE = "/e/backoffice/products/delete";
        const string API_URL_PRODUCTS_GET = "/e/backoffice/products/status";
        const string API_URL_LABELS_GET = "/e/backoffice/labels/status";
        const string API_URL_LABELS_ASSIGN = "/e/backoffice/labels/assign";
        const string API_URL_LABELS_UNASSIGN = "/e/backoffice/labels/unassign";

        private string publicKey = "";
        private string privateKey = "";

        public PovelliAPI(string publicKey, string privateKey)
        {
            this.publicKey = publicKey;
            this.privateKey = privateKey;
        }

        protected string getSignature(string method, string path, string timestamp)
        {
            string[] textArr = { this.publicKey, timestamp, method, path };
            string text = String.Join("\n", textArr);
            var hmac = new HMACSHA256(Encoding.ASCII.GetBytes(this.privateKey));
            var hash = hmac.ComputeHash(Encoding.ASCII.GetBytes(text));
            return Convert.ToBase64String(hash);
        }

        protected byte [] dataToJson(Object [] data, Type dataType) {
            DataContractJsonSerializer jsonSer = new DataContractJsonSerializer(dataType);
            MemoryStream ms = new MemoryStream();
            jsonSer.WriteObject(ms, data);
            //string json = Encoding.UTF8.GetString(ms.ToArray());
            return ms.ToArray();
        }

        protected PovelliResponse sendRequest(string domain, string path, 
            byte[] payload, string method = "POST")
        {
            HttpWebRequest request = HttpWebRequest.Create("https://" + domain + path) as HttpWebRequest;

            request.Method = method;
            request.ContentType = "application/json";
            request.Accept = "application/json";

            string timestamp =  (DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds.ToString();
            request.Headers.Add("PV-Signature: " + this.getSignature(request.Method, path, timestamp));
            request.Headers.Add("PV-Timestamp: " + timestamp);
            request.Headers.Add("PV-Public-Key: " + publicKey);
            request.UserAgent = ".NET-requests";

            request.ContentLength = payload.Length;
            request.GetRequestStream().Write(payload, 0, payload.Length);

            string payloadStr = System.Text.Encoding.Default.GetString(payload);

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

        public PovelliResponse updateProducts(PovelliProduct [] products)
        {
            PovelliResponse res = this.sendRequest(
                PovelliAPI.DEFAULT_API_DOMAIN, PovelliAPI.API_URL_PRODUCTS_UPDATE,
                this.dataToJson(products, typeof(PovelliProduct[])));
            return res;
        }

        public PovelliResponse deleteProducts(PovelliProductFilter [] products)
        {
            PovelliResponse res = this.sendRequest(
                PovelliAPI.DEFAULT_API_DOMAIN, PovelliAPI.API_URL_PRODUCTS_DELETE,
                this.dataToJson(products, typeof(PovelliProductFilter[])), "DELETE");
            return res;
        }

        public PovelliResponse getProducts(PovelliProductFilter[] products)
        {
            PovelliResponse res = this.sendRequest(
                PovelliAPI.DEFAULT_API_DOMAIN, PovelliAPI.API_URL_PRODUCTS_GET,
                this.dataToJson(products, typeof(PovelliProductFilter[])));
            return res;
        }

        public PovelliTemplate [] getLabelTemplates(string storeUid, string labelBarcode)
        {
            PovelliLabelFilter[] labelFilters = new PovelliLabelFilter[1];
            labelFilters[0] = new PovelliLabelFilter(storeUid, labelBarcode);

            PovelliResponse res = this.sendRequest(
                PovelliAPI.DEFAULT_API_DOMAIN, PovelliAPI.API_URL_LABELS_GET,
                this.dataToJson(labelFilters, typeof(PovelliLabelFilter[])));

            PovelliTemplate[] templates = null;
            if (res.success && res.labels.Length > 0) {
                templates = res.labels[0].available_templates;
            }

            return templates;
        }

        public PovelliResponse assignLabels(PovelliLabelAssignment[] labelAssignments)
        {
            PovelliResponse res = this.sendRequest(
                PovelliAPI.DEFAULT_API_DOMAIN, PovelliAPI.API_URL_LABELS_ASSIGN,
                this.dataToJson(labelAssignments, typeof(PovelliLabelAssignment[])));
            return res;
        }

        public PovelliResponse unassignLabels(PovelliLabelFilter[] labels)
        {
            PovelliResponse res = this.sendRequest(
                PovelliAPI.DEFAULT_API_DOMAIN, PovelliAPI.API_URL_LABELS_ASSIGN,
                this.dataToJson(labels, typeof(PovelliLabelFilter[])));
            return res;
        }
    }
}
