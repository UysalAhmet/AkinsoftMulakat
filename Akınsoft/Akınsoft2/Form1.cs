using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akınsoft2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            HttpResponseMessage response =await client.GetAsync("http://eliza.akinsoft.net/module/api/programapi/programdetayi?prog_kodu=ISC1");
            string result = await response.Content.ReadAsStringAsync();
			JsonToTree.LoadJsonToTreeView(this.treeView1, result);
           
        }
	
	}
}
