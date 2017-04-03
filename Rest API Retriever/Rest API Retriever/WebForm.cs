using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotLiquid;

namespace SBR_DocDesigner
{
    public partial class WebForm : Form
    {
        public WebForm(String url)
        {
            InitializeComponent();              
            //webBrowser1.DocumentText = temp.Render(Hash.FromAnonymousObject(new { name = "tobi" }));
            webBrowser1.DocumentText = url;
        }
    }
}
