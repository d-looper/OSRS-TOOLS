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
                string p = ".\\Schema\\";
                list = getFields(address, apiKey, p);
                return list;
            }
            // customers
            else if (wID == 2)
            {
                string address = url + "/api/customers";
                string p = ".\\Schema\\Customers.json";
                list = getFields(address, apiKey, p);
                return list;

            }
            // inventory
            else if (wID == 3)
            {
                string address = url + "/api/items";
                string p = ".\\Schema\\Inventory.json";
                list = getFields(address, apiKey, p);
                return list;

            }
            // tickets
            else if (wID == 4)
            {
                string address = url + "/api/sales/tickets";
                string p = ".\\Schema\\Tickets.json";
                list = getFields(address, apiKey, p);
                return list;

            }
            // sales orders
            else if (wID == 5)
            {
                string address = url + "/api/sales/orders";
                string p = ".\\Schema\\Orders.json";
                list = getFields(address, apiKey, p);
                return list;

            }
            // PO
            else if (wID == 6)
            {
                string address = url + "/api/purchasing/orders";
                string p = ".\\Schema\\PO.json";
                list = getFields(address, apiKey, p);
                return list;

            }
            // PR
            else if (wID == 7)
            {
                string address = url + "/api/purchasing/receipts";
                string p = ".\\Schema\\PR.json";
                list = getFields(address, apiKey, p);
                return list;
            }
            // PRet
            else if (wID == 8)
            {
                string address = url + "/api/purchasing/returns";
                string p = ".\\Schema\\PRet.json";
                list = getFields(address, apiKey, p);
                return list;
            }
            // Settings
            else if (wID == 9)
            {
                string address = url + "/api/settings";
                string p = ".\\Schema\\Settings.json";
                list = getFields(address, apiKey, p);
                return list;
            }


            return list;
        }

        public List<string> getFields(string address, string apiKey, string path)
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
                var _results = JObject.Parse(File.ReadAllText(path));
                //JToken _results = results["results"][0];
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
                    list.Add(cf.Name + " (Custom)");
                }

            }
            catch(Exception e)
            {
                list = null;
                return list;
            }
            return list;
        }
    }
}
