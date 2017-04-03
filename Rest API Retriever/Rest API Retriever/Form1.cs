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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace SBR_DocDesigner
{
    public partial class Form1 : Form
    {     
 
        public Form1()
        {
            InitializeComponent();
            
            int i = 0;
            var json = JObject.Parse(File.ReadAllText("Springboard.json"));
            var dJson = JObject.Parse(File.ReadAllText("DefaultDesigns.json"));
            foreach (var cust in json["Records"])
            {
                comboBox1.Items.Add(cust.First.First);
                i++;
            }
            i = 0;
            foreach (var design in dJson["Records"])
            {
                cbDesign.Items.Add(design.First.First);
                i++;
            }
            lblAPI.Text = "";
            rbTest.Checked = true;
            rbCustomer.Checked = true;
            comboBox1.SelectedIndex = 0;
            cbDesign.SelectedIndex = 0;            
            //btnPut.Enabled = false; ;
        }

        private void SBTab_Click(object sender, EventArgs e)
        {

        }
        
        private void btnPut_Click(object sender, EventArgs e)
        {
            // add functionality to write text to json file under design[] as a backup system for custom designs
            putRequest();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int index = comboBox1.SelectedIndex;
            var json = JObject.Parse(File.ReadAllText("Springboard.json"));
            var accounts = json["Records"][index]["Site"].ToList();
            
            if (accounts.Count == 1)
            {
                rbPro.Enabled = false;
                rbTest.Enabled = true;
            }
            else
            {
                rbPro.Enabled = true;
            }
            getKey(index);
            prepData();
        }

        private void rbTest_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTest.Checked == true)
                rbPro.Checked = false;
            int index = comboBox1.SelectedIndex;
            getKey(index);
        }

        private void rbPro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPro.Checked == true)
                rbTest.Checked = false;
            int index = comboBox1.SelectedIndex;
            getKey(index);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateDefaultTemplatesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void getKey(int index)
        {
            if (index < 0)
                index = 0;
            var json = JObject.Parse(File.ReadAllText("Springboard.json"));
            string api = "";
            if (rbTest.Checked)
                api = json["Records"][index]["Site"][0]["APIKey"].ToString();
            
            if (rbPro.Checked)            
                api = json["Records"][index]["Site"][1]["APIKey"].ToString();
            
            lblAPI.Text = api;
            //lblAPI.Refresh();
        }

        private void cbDesign_SelectedIndexChanged(object sender, EventArgs e)
        {
            prepData();       
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            tbResponse.Clear();
        }

        private string getTemplateAddress()
        {            
            var json = JObject.Parse(File.ReadAllText("Springboard.json"));
            int index = comboBox1.SelectedIndex;
            if (index < 0)
                index = 0;
            string tempAdd = json["Records"][index]["Template"].ToString();
            int accIndex = 0;
            if (rbTest.Checked == true)
                accIndex = 0;
            else
                accIndex = 1;            
            string site = json["Records"][index]["Site"][accIndex]["Address"].ToString();         
            return site;
        }

        private string getTemplate()
        {            
            var json = JObject.Parse(File.ReadAllText("Springboard.json"));
            int index = comboBox1.SelectedIndex;
            if (index < 0)
                index = 0;
            string tempAdd = json["Records"][index]["Template"].ToString();            
            return tempAdd;
        }

        private void rbDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDefault.Checked == true)
            {
                rbCustomer.Checked = false;
                rbBackup.Checked = false;
            }
            prepData();
        }

        private void rbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustomer.Checked == true)
            {
                rbDefault.Checked = false;
                rbBackup.Checked = false;
            }
            prepData();
        }

        private void rbBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBackup.Checked == true)
            {
                rbDefault.Checked = false;
                rbCustomer.Checked = false;
            }
            prepData();
        }

        private string restGet(string address, string apiKey, string template, string docName, int func)
        {

            if (func == 0)
            {
                if (docName != null)
                    template = template + "/" + docName;
                var client = new RestClient(address);
                var request = new RestRequest(template, Method.GET);
                request.AddHeader("Authorization", apiKey);
                IRestResponse response = client.Execute(request);
                var result = response.Content;
                try
                {

                    JObject results = JObject.Parse(result);
                    result = results["content"].ToString();
                }
                catch
                {
                    return result;
                }
                return result;
            }

            else
            {
                var client = new RestClient(address);
                var request = new RestRequest(template + "?per_page=50", Method.GET);
                request.AddHeader("Authorization", apiKey);                
                IRestResponse response = client.Execute(request);
                var result = response.Content;
                try
                {

                    JObject results = JObject.Parse(result);
                    result = results["content"].ToString();
                }
                catch
                {
                    return result;
                }
                return result;
            }
            
        }

        private string getDefaults()
        {
            int index = cbDesign.SelectedIndex;
            var dJson = JObject.Parse(File.ReadAllText("DefaultDesigns.json"));
            string result = dJson["Records"][index]["content"].ToString();
            return result;
        }

        private void prepData()
        {
            var json = JObject.Parse(File.ReadAllText("DefaultDesigns.json"));
            string result = "";            
            string address = getTemplateAddress();
            string templates = getTemplate();
            string apiKey = lblAPI.Text;
            string docName = getDoc();
            if (rbCustomer.Checked == true)
                result = restGet(address, apiKey, templates, docName, 0);
            else if (rbBackup.Checked == true)
                result = getBackup(); // add function to get backed up design data here
            else
                result = getDefaults();            
            tbResponse.Clear();
            tbResponse.Text = result.ToString();
        }

        private void putRequest()
        {
            string apiKey = lblAPI.Text;            
            string content = tbResponse.Text;
            string address = getTemplateAddress();
            string template = getTemplate();
            string docName = getDocTemplate();
            var docTemplate = JObject.Parse(docName);
            docTemplate["content"] = content;
            docTemplate["updated_at"] = DateTime.Now;
            string name = docTemplate["id"].ToString();
            string body = docTemplate.ToString();

            if (docName != null)
                template = template + "/" + name;
            var client = new RestClient(address);
            var request = new RestRequest(template, Method.PUT);
            request.AddHeader("Authorization", apiKey);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var result = response.ResponseStatus;
            //saveBackup(0);
            tbResponse.Text = result.ToString();
            
            
        }
        private string getDoc()
        {
            string docName = "";
            var json = JObject.Parse(File.ReadAllText("DefaultDesigns.json"));
            int doc = cbDesign.SelectedIndex;
            if (doc < 0)
                doc = 0;
            docName = json["Records"][doc]["id"].ToString();
            return docName;
        }

        private string getDocTemplate()
        {
            string docName = "";
            var json = JObject.Parse(File.ReadAllText("DefaultDesigns.json"));
            int doc = cbDesign.SelectedIndex;
            if (doc < 0)
                doc = 0;
            docName = json["Records"][doc].ToString();
            return docName;
        }

        private void saveBackup(int id)
        {
            int Cindex = comboBox1.SelectedIndex;
            var json = JObject.Parse(File.ReadAllText("Springboard.json"));
            string saveLoc = SBR_DocDesigner.Properties.Settings.Default.SaveLocation;
            string custName = json["Records"][Cindex]["Name"].ToString();
            string address = getTemplateAddress();
            string templates = getTemplate();
            string apiKey = lblAPI.Text;                     
            string result = restGet(address, apiKey, templates, null, 1);

            if (!File.Exists(saveLoc + custName + ".json"))
            {
                var myFile = File.Create(saveLoc + custName + ".json");
                myFile.Close();                
            }

            string jsonFormatted = JValue.Parse(result).ToString(Formatting.Indented);
            File.WriteAllText(saveLoc + custName + ".json", jsonFormatted);

            if(id == 1)
                MessageBox.Show("Designs backed up");

        }

        private string getBackup()
        {
            int Cindex = comboBox1.SelectedIndex;
            var json = JObject.Parse(File.ReadAllText("Springboard.json"));
            string account = json["Records"][Cindex]["Name"].ToString();
            // check if file exists here
            int index = cbDesign.SelectedIndex;
            var dJson = JObject.Parse(File.ReadAllText(SBR_DocDesigner.Properties.Settings.Default.SaveLocation + account + ".json"));
            string result = dJson["results"][index]["content"].ToString();
            return result;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {            
            saveBackup(1);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            String url = tbResponse.Text; // string from text box
            string nurl = url.Replace("{{logo_url}}", "Images/logo.jpg");
            WebForm prev = new WebForm(nurl);            
            prev.Show();          
           
        }
    }
}
