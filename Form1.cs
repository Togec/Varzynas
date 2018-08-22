using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;



namespace Varzynas
{
    public partial class Form1 : Form
    {
        byte[] OutMas = new byte[0xff];
        byte num;
        public Form1()
        {
            InitializeComponent();
            getAvailablePorts();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CMD_send(0x10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CMD_send(0x11);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CMD_send(0x12);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CMD_send(0x13);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CMD_send(0x14);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CMD_send(0x15);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CMD_send(0x16);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CMD_send(0x20);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CMD_send(0x21);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CMD_send(0x22);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CMD_send(0x23);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CMD_send(0x24);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CMD_send(0x25);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            CMD_send(0x26);
        }

        void getAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
            comboBox1.Sorted = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void CMD_send(byte cmd_code)
        {   
            serialPort1.PortName = comboBox1.Text;
            serialPort1.Open();

            string adresas = textBox1.Text;
            int num = Int32.Parse(adresas, System.Globalization.NumberStyles.HexNumber);
            byte b = (byte) num; 

            OutMas[0] = 0xAA;
            OutMas[1] = b;
            OutMas[2] = cmd_code;
            OutMas[3] = 0x0D;

            serialPort1.Write(OutMas, 0, 4);

            serialPort1.Close();

        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
