using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_Calcular (object sender, EventArgs e)
        {
            decimal valor = nudIn.Value;
            decimal respuesta;
            if (cbIn.Text.Equals("CELSIUS"))
            {
                switch (cbOut.Text)
                {
                    case "CELSIUS":
                        txtOut.Text = "" + valor;
                        break;
                    case "FAHRENHEIT":
                        respuesta = ((valor * 9) / 5) + 32;
                        txtOut.Text = "" + respuesta;
                        break;
                    case "KELVIN":
                        respuesta = valor + 273.15m;
                        txtOut.Text = "" + respuesta;
                        break;
                }
            }
            else if (cbIn.Text.Equals("FAHRENHEIT"))
            {
                switch (cbOut.Text)
                {
                    case "CELSIUS":
                        respuesta = ((valor - 32) * 5) / 9;
                        txtOut.Text = "" + respuesta;
                        break;
                    case "FAHRENHEIT":
                        txtOut.Text = "" + valor;
                        break;
                    case "KELVIN":
                        respuesta = (((valor - 32) * 5) / 9) + 273.15m;
                        txtOut.Text = "" + respuesta;
                        break;
                }
            }
            else
            {
                switch (cbOut.Text)
                {
                    case "CELSIUS":
                        respuesta = valor - 273.15m;
                        txtOut.Text = "" + respuesta;
                        break;
                    case "FAHRENHEIT":
                        respuesta = (((valor - 273.15m) * 9) / 5) + 32;
                        txtOut.Text = "" + respuesta;
                        break;
                    case "KELVIN":
                        txtOut.Text = "" + valor;
                        break;
                }
            }
        }

        private void cbIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOut.Text = "";
        }

        private void cbOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOut.Text = "";
        }
    }
}
