using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcular_peso04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(box1.Text, out double peso) &&
                double.TryParse(box2.Text, out double altura) &&
                altura > 0)
            {
                double imc = peso / (altura * altura);
                string categoria;

                if (imc < 18.5)
                    categoria = "Bajo peso";
                else if (imc < 25)
                    categoria = "Normal";
                else if (imc < 30)
                    categoria = "Sobrepeso";
                else
                    categoria = "Obesidad";

                box3.Text = $"{imc:F2} - {categoria}";
            }
            else
            {
                box3.Text = "Por favor, ingrese valores válidos.";
            }
        }
    }
}
