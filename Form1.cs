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

namespace serv_serial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SerialPort motor = new SerialPort("COM5", 9600);
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            label1.Text = "Motor açısı: " + Convert.ToString(trackBar1.Value) + "°";
            int deger = trackBar1.Value;
            byte[] d = BitConverter.GetBytes(deger);
            motor.Write(d, 0, 4);



        }

        public void Form1_Load(object sender, EventArgs e)
        {
            motor.Open();
            trackBar1.Value = 90;
            label1.Text = "Motor açısı: " + Convert.ToString(trackBar1.Value) + "°";
            int deger = trackBar1.Value;
            byte[] d = BitConverter.GetBytes(deger);
            motor.Write(d, 0, 4);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 1;
            label1.Text = "Motor açısı: " + "0°";
            int deger = trackBar1.Value;
            byte[] d = BitConverter.GetBytes(deger);
            motor.Write(d, 0, 4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 180;
            label1.Text = "Motor açısı: " + Convert.ToString(trackBar1.Value) + "°";
            int deger = trackBar1.Value;
            byte[] d = BitConverter.GetBytes(deger);
            motor.Write(d, 0, 4);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 90;
            label1.Text = "Motor açısı: " + Convert.ToString(trackBar1.Value) + "°";
            int deger = trackBar1.Value;
            byte[] d = BitConverter.GetBytes(deger);
            motor.Write(d, 0, 4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {

                for (int j = 50; j < 180;j++)
                {
                    trackBar1.Value = j;
                    label1.Text = "Motor açısı: " + Convert.ToString(trackBar1.Value) + "°";
                    int deger = trackBar1.Value;
                    byte[] d = BitConverter.GetBytes(deger);
                    motor.Write(d, 0, 4);

                }
                for (int j = 50; j < 180; j++)
                {
                    trackBar1.Value = (180 - j);
                    label1.Text = "Motor açısı: " + Convert.ToString(trackBar1.Value) + "°";
                    int deger = trackBar1.Value;
                    byte[] d = BitConverter.GetBytes(deger);
                    motor.Write(d, 0, 4);

                }
                trackBar1.Value = 90;
                label1.Text = "Motor açısı: " + Convert.ToString(trackBar1.Value) + "°";
                int deger2 = trackBar1.Value;
                byte[] d1 = BitConverter.GetBytes(deger2);
                motor.Write(d1, 0, 4);

            }
        }
    }
}
