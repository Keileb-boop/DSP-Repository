using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        //crea lista privada llamada NumPositivos que almacenará números decimales positivos.
        private List<decimal> NumPositivos = new List<decimal>();
        //crea lista privada llamada NumNegativos almacena números decimales negativos.
        private List<decimal> NumNegativos = new List<decimal>();
        //e utiliza para llevar un conteo de cuántos números se han ingresado hasta el momento
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void lstNumNegativos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /* decimal.TryParse intenta convertir el texto ingresado en un número decimal(number).
           Si la conversión es exitosa, number contendrá el valor decimal y TryParse devolverá true.
           Si la conversión falla, TryParse devolverá false.*/
            if (decimal.TryParse(txtNum.Text, out decimal number))
            {
                // Verifica si el número es positivo o negativo y lo agrega a la lista correspondiente
                if (number >= 0)
                {
                    NumPositivos.Add(number);
                    lstNumPoitivos.Items.Add(number);
                }
                else
                {
                    NumNegativos.Add(number);
                    lstNumNegativos.Items.Add(number);
                }

                // Incrementa el contador de números ingresados
                count++;
                txtNum.Clear(); // Limpia el TextBox para ingresar el siguiente número
                // Desactiva el botón de agregar números y activa el botón de calcular cuando se ingresan 10 números
                if (count == 10)
                {
                    btnAgregar.Enabled = false;
                    btnCalcular.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresa un número decimal válido");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (NumNegativos.Count > 0)
            {
                decimal minNegative = NumNegativos.Min();
                lblMinNegativo.Text = "Número menor negativos: " + minNegative;
            }
            else
            {
                lblMinNegativo.Text = "No se ingresaron números negativos.";
            }
            if (NumPositivos.Count > 0)
            {
                decimal averagePositive = NumPositivos.Average();
                lblPromNegativos.Text = "Promedio de los positivos: " + averagePositive;
            }
            else
            {
                lblPromNegativos.Text = "No se ingresaron números positivos.";
            }
        }
    }
}


