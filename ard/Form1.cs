using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            /*Console.WriteLine(serialPort1.ReadLine());
            try
            {
double a = Convert.ToDouble(serialPort1.ReadLine()) * 5 / 1023;
            label1.Text = a.ToString();
            }
            catch (Exception)
            {

                
            }*/
            
        }
       
        

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            serialPort1.Open();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            String data = serialPort1.ReadLine();
            String[] values = data.Split(',');
            for (int i = 0; i < values.Length; i++)
            {
                String text = "Val1: " + values[0] + '\n';
                label2.Text = text;
            }
            //String a1 = null;
            //for(int i=0; i<5; i++) { 
            // a1 += serialPort1.ReadLine();
            //}
            //label2.Text = a1;
            
        }
    }
}
