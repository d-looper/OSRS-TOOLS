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

namespace Springboard_Data_Migration
{
    public partial class Form1 : Form
    {
        string url;
        int wID;
        Import imp = new Import();

        public Form1()
        {
            InitializeComponent();

            if(Springboard_Data_Migration.Properties.Settings.Default.useTest == true)
            {
                tbURL.Text = Springboard_Data_Migration.Properties.Settings.Default.url;
                tbAPI.Text = Properties.Settings.Default.apiKey;
            }
            
        }

        private void tbURL_TextChanged(object sender, EventArgs e)
        {
            url = tbURL.Text;
        }

        private void btnVen_Click(object sender, EventArgs e)
        {
            wID = 1;
            loadFile(wID);
        }

        private void btnCust_Click(object sender, EventArgs e)
        {
            wID = 2;
            loadFile(wID);
        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            wID = 3;
            loadFile(wID); wID = 2;
            loadFile(wID);
        }

        private void btnTick_Click(object sender, EventArgs e)
        {
            wID = 4;
            loadFile(wID);
        }

        private void btnSO_Click(object sender, EventArgs e)
        {
            wID = 5;
            loadFile(wID);
        }

        private void btnPO_Click(object sender, EventArgs e)
        {
            wID = 6;
            loadFile(wID);
        }

        private void btnPR_Click(object sender, EventArgs e)
        {
            wID = 7;
            loadFile(wID);
        }

        private void btnPRet_Click(object sender, EventArgs e)
        {
            wID = 8;
            loadFile(wID);
        }

        private void btnSett_Click(object sender, EventArgs e)
        {
            wID = 9;
            loadFile(wID);
        }

        public void loadFile(int wID)
        {
            openFileDialog1.Filter = "CSV|*.csv";
            openFileDialog1.Title = "Select CSV file to import";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // read file into table in UI  
                dgVen.Rows.Clear();
                dgVen.Columns.Clear();
                dgVen.Refresh();
                string api = tbAPI.Text;
                              
                var dict = File.ReadLines(openFileDialog1.FileName).Select(line => line.Split(',')).ToList();
                List<string> customF = imp.cFields(wID, api, url);
                int k = 0;
                //int start = 0;

                foreach (var hdr in dict[0])
                {
                    DataGridViewComboBoxCell cbox = new DataGridViewComboBoxCell();

                    foreach (string fld in customF)
                    {
                        cbox.Items.Add(fld);
                    }
                    dgVen[k, 0] = cbox;
                    //dgVen.Columns.Add((k+1).ToString(), hdr.ToString());
                    k++;
                }

                //dict.RemoveAt(0);

                int count = dict.Count();
                int i = 0;

                foreach (var data in dict)
                {

                    DataGridViewRow row = (DataGridViewRow)dgVen.Rows[i].Clone();
                    int j = 0;

                    foreach (var field in data)
                    {                        
                        row.Cells[j].Value = field.ToString();
                        
                        j++;
                    }

                    dgVen.Rows.Add(row);

                    i++;
                }
                // create dropdown menus from fields for number of columns
            }
        }
               
    }
}
