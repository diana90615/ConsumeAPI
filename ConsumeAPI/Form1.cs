using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumeAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.DataSource = Enum.GetValues(typeof(httpVerb));


        }


        private void button1_Click(object sender, EventArgs e)
        {

            RestClient rClient = new RestClient();
            rClient.endPoint = textBox1.Text;
            rClient.httpMethod = (httpVerb)comboBox1.SelectedItem;

            textBox2.Text = rClient.makeRequest();
        }
    }
}
