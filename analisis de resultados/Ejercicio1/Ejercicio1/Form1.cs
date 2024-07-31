using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los números del usuario
                decimal[] numbers = new decimal[10];
                for (int i = 0; i < 10; i++)
                {
                    TextBox textBox = this.Controls["textBox" + (i + 1)] as TextBox;
                    if (textBox != null && decimal.TryParse(textBox.Text, out decimal number))
                    {
                        numbers[i] = number;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingresa un número decimal válido en todas las casillas.");
                        return;
                    }
                }
                // Obtener la opción seleccionada
                string option = this.cbxOpcion.SelectedItem.ToString();
                string result = "";

                switch (option)
                {
                    case "a":
                        decimal minNegative = decimal.MaxValue;
                        decimal maxNegative = decimal.MinValue;
                        decimal sumPositive = 0;
                        int countPositive = 0;

                        foreach (var num in numbers)
                        {
                            if (num < 0)
                            {
                                if (num < minNegative) minNegative = num;
                                if (num > maxNegative) maxNegative = num;
                            }
                            else
                            {
                                sumPositive += num;
                                countPositive++;
                            }
                        }

                        if (minNegative == decimal.MaxValue)
                        {
                            minNegative = 0; // No hay negativos, así que se establece en 0
                        }
                        if (maxNegative == decimal.MinValue)
                        {
                            maxNegative = 0; // No hay negativos, así que se establece en 0
                        }

                        if (countPositive > 0)
                        {
                            decimal avgPositive = sumPositive / countPositive;
                            result = $"Número menor negativo: {minNegative}\nNúmero mayor negativo: {maxNegative}\nPromedio de los positivos: {avgPositive}";
                        }
                        else
                        {
                            result = $"Número menor negativo: {minNegative}\nNúmero mayor negativo: {maxNegative}\nNo hay números positivos.";
                        }
                        break;

                    case "b":
                        decimal sumAll = 0;
                        foreach (var num in numbers)
                        {
                            sumAll += num;
                        }
                        decimal averageAll = sumAll / numbers.Length;
                        result = $"Media de toda la serie: {averageAll}";
                        break;

                    default:
                        result = "Opción no válida.";
                        break;
                }

                this.lblResultados.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}");
            }
        }
    }
}


