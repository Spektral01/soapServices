using ClientSOAP.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClientSOAP
{


    public partial class Form1 : Form
    {
        private ClientSOAP.ServiceReference1.SoapServiceClient serviceClient;

        public Form1()
        {
            InitializeComponent();
            serviceClient = new ClientSOAP.ServiceReference1.SoapServiceClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputString = textBox1.Text;
            if(!String.IsNullOrEmpty(inputString) ) 
            {
                string result = serviceClient.MaxChar(inputString);
                label1.Text= result;
            }
        }
    }
}
