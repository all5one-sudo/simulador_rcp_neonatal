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
using System.Threading;

namespace HMIArduino
{
    public partial class Form1 : Form
    {
        List<double> dataArray = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonClose.Enabled = false;
            buttonOpen.Enabled = true;
            buttonIniciar.Enabled = false;
            buttonFinalizar.Enabled = false;    
            comboBoxBaud.Text = "9600";
            progressBarConnection.Value = 0;
            string[] portList = SerialPort.GetPortNames();
            comboBoxPort.Items.AddRange(portList);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBoxPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBaud.Text);
                serialPort1.Open();
                buttonOpen.Enabled = false;
                buttonClose.Enabled = true;
                progressBarConnection.Value = 100;
                comboBoxBaud.Enabled = false;
                comboBoxPort.Enabled = false;
                buttonIniciar.Enabled = true;
                buttonFinalizar.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    buttonClose.Enabled = false;
                    buttonOpen.Enabled = true;
                    comboBoxBaud.Text = "9600";
                    progressBarConnection.Value = 0;
                    comboBoxBaud.Enabled = true;
                    comboBoxPort.Enabled = true;
                    buttonIniciar.Enabled = false;
                    buttonFinalizar.Enabled = false;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void buttonOpen_MouseHover(object sender, EventArgs e)
        {

        }

        private void buttonClose_MouseHover(object sender, EventArgs e)
        {

        }

        private void buttonOpen_MouseEnter(object sender, EventArgs e)
        {
            buttonOpen.BackColor = Color.Aqua;
        }

        private void buttonOpen_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Silver;
        }

        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Aqua;
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonOpen.BackColor = Color.Silver;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            while(serialPort1.IsOpen && serialPort1.BytesToRead > 0)
            {
                string serialData = serialPort1.ReadLine();
                //int values = Convert.ToInt32(serialData);
                //double value = values / 3.5;
                double value = Convert.ToDouble(serialData);
                value = value / 100.0;
                //chart1.Series["Distancia"].Points.Add(value);
                chart1.Invoke((MethodInvoker)(() => chart1.Series["Distancia"].Points.AddY(value)));
                //chart1.Invoke((MethodInvoker)(() => chart1.Series["Limite"].Points.AddY(5.42)));
                //chart1.Invoke((MethodInvoker)(() => chart1.Series["Limite2"].Points.AddY(6.48)));
                dataArray.Add(value);
                Thread.Sleep(100);
            }
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            //List<double> data = new List<double>();
            buttonFinalizar.Enabled = true;
            /*while (serialPort1.IsOpen && serialPort1.BytesToRead > 0)
            {
                string serialData = serialPort1.ReadLine();
                double value = Convert.ToDouble(serialData);
                value = value / 100.0;
                dataArray.Append(value);
            }*/
            //double[] myArray = data.ToArray();
            /*for (int i = 0; i < myArray.Length; i++)
            {
                dataArray[i] = myArray[i];
            }*/
            //dataArray = myArray;
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            int contleves = 0;
            int contbien = 0;
            int contexceso = 0;
            int ciclos = 0;
            double[] myArray = dataArray.ToArray(); 
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < 8 && myArray[i - 1] > 8)
                {
                    ciclos++;
                    if (myArray[i] < 8 && myArray[i] >= 6.38)
                    {
                        contleves++;
                    }
                    else if (myArray[i] < 6.38 && myArray[i] >= 5.42)
                    {
                        contbien++;
                    }
                    else if (myArray[i] < 5.42)
                    {
                        contexceso++;
                    }
                }
            }
            int porcentajeLeves = (contleves / (contleves + contbien + contexceso));
            int porcentajeOptimos = (contbien / (contleves + contbien + contexceso));
            int porcentajeExcesos = (contexceso / (contleves + contbien + contexceso));
            circularProgressBarExcesos.Value = 100 * porcentajeExcesos;
            circularProgressBarLeves.Value = 100 * porcentajeLeves;
            circularProgressBarOptimos.Value = 100 * porcentajeOptimos;
            circularProgressBarExcesos.Text = Convert.ToString(contexceso);
            circularProgressBarLeves.Text = Convert.ToString(contleves);
            circularProgressBarOptimos.Text = Convert.ToString(contbien);
        }
    }
}
