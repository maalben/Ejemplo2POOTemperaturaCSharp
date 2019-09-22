using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2POOTemperaturaCSharp
{
    public partial class Form1 : Form
    {
        Temperatura temperatura = new Temperatura();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            
            switch (cmbtipogrado.SelectedIndex.ToString())
            {
                case "1":
                    temperatura.setGrados(double.Parse(txtgrados.Text));
                    lblresultado.Text = temperatura.calcularFarenheit().ToString() + " °F";
                    lblresultado.Visible = true;
                    break;

                case "2":
                    temperatura.setGrados(double.Parse(txtgrados.Text));
                    lblresultado.Text = temperatura.calcularCentigrados().ToString() + " °C";
                    lblresultado.Visible = true;
                    break;


                default:
                    MessageBox.Show("Debes seleccionar una opción válida");
                    break;
            }

            
        }
    }
}
