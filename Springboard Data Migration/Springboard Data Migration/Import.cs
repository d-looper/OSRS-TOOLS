using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace Springboard_Data_Migration
{
    class Import
    {
        public List<string> cFields(int wID, string apiKey, string url)
        {
            List<string> list = new List<string>();

            // vendors
            if (wID == 1)
            {
                string address = url + "/api/vendors";
                list = getFields(address, apiKey);
                return list;               
            }
            // customers
            else if (wID == 2)
            {
                string address = url + "/api/customers";
                list = getFields(address, apiKey);
                return list;

            }
            // inventory
            else if (wID == 3)
            {
                string address = url + "/api/items";
                list = getFields(address, apiKey);
                return list;

            }
            // tickets
            else if (wID == 4)
            {
                string address = url + "/api/sales/tickets";
                list = getFields(address, apiKey);
                return list;

            }
            // sales orders
            else if (wID == 5)
            {
                string address = url + "/api/sales/orders";
                list = getFields(address, apiKey);
                return list;

            }
            // PO
            else if (wID == 6)
            {
                string address = url + "/api/purchasing/orders";
                list = getFields(address, apiKey);
                return list;

            }
            // PR
            else if (wID == 7)
            {
                string address = url + "/api/purchasing/receipts";
                list = getFields(address, apiKey);
                return list;
            }
            // PRet
            else if (wID == 8)
            {
                string address = url + "/api/purchasing/returns";
                list = getFields(address, apiKey);
                return list;
            }
            // Settings
            else if (wID == 9)
            {
                string address = url + "/api/settings";
                list = getFields(address, apiKey);
                return list;
            }
            

            return list;
        }

        public List<string> getFields(string address, string apiKey)
        {
            List<string> list = new List<string>();
            var client = new RestClient(address);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer " + apiKey);
            IRestResponse response = client.Execute(request);
            var result = response.Content;
            try
            {

                JObject results = JObject.Parse(result);
                JToken _results = results["results"][0];
                JToken _cresults = results["results"][0]["custom"];
                //result = results["content"].ToString();
                var ddlist = _results.Children();
                var cflist = _cresults.Children();
                foreach (JProperty dd in ddlist)
                {
                    list.Add(dd.Name);
                }
                foreach (JProperty cf in cflist)
                {
                    list.Add(cf.Name);
                }

            }
            catch
            {
                list = null;
                return list;
            }
            return list;
        }
    }
}
