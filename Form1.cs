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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if(radioButton1.Checked)
             {
                CMD_send(0x10);
             }

            if (radioButton2.Checked)
            {
                CMD_send(0x11);
            }

            if (radioButton3.Checked)
            {
                CMD_send(0x12);
            }

            if (radioButton4.Checked)
            {
                CMD_send(0x13);
            }

            if (radioButton5.Checked)
            {
                CMD_send(0x14);
            }

            if (radioButton6.Checked)
            {
                CMD_send(0x15);
            }

            if (radioButton7.Checked)
            {
                CMD_send(0x16);
            }


            if (radioButton8.Checked)
            {
                CMD_send(0x20);
            }

            if (radioButton9.Checked)
            {
                CMD_send(0x21);
            }

            if (radioButton10.Checked)
            {
                CMD_send(0x22);
            }

            if (radioButton11.Checked)
            {
                CMD_send(0x23);
            }

            if (radioButton12.Checked)
            {
                CMD_send(0x24);
            }

            if (radioButton13.Checked)
            {
                CMD_send(0x25);
            }

            if (radioButton14.Checked)
            {
                CMD_send(0x26);
            }
        }
    }
}
