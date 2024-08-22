using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorTemperaturaLFVO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtCelsius_Click(object sender, EventArgs e)
        {
            txtFahrenheit.ReadOnly = true;
            txtCelsius.ReadOnly = true;
            BtCelsius.Enabled = false;
            BtFahrenheit.Enabled = false;

            float fahrenheit = float.Parse(txtFahrenheit.Text);
            float celsius = (fahrenheit - 32) * 5.0f / 9.0f;
            txtCelsius.Text = celsius.ToString();
        }

        private void BtFahrenheit_Click(object sender, EventArgs e)
        {
            txtFahrenheit.ReadOnly = true;
            txtCelsius.ReadOnly = true;
            BtCelsius.Enabled = false;
            BtFahrenheit.Enabled = false;

            float celsius = float.Parse(txtCelsius.Text); 
            float fahrenheit = (celsius * 9 / 5f) + 32;
            txtFahrenheit.Text = fahrenheit.ToString();
        }

        private void LimpiarBT_Click(object sender, EventArgs e)
        {
            txtFahrenheit.ReadOnly = false;
            txtCelsius.ReadOnly = false;
            BtCelsius.Enabled = true;
            BtFahrenheit.Enabled = true;

            txtFahrenheit.Text = "";
            txtCelsius.Text = "";
            MessageBox.Show("Se han reseteado los valores.");
        }

    }
}
