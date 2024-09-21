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
        public Form1()
        {
            InitializeComponent();
        }

        // Método para calcular los resultados estadísticos y mostrarlos en el ListBox
        private void CalcularEstadisticas(List<double> notas, ListBox listBox)
        {
            if (notas == null || notas.Count == 0)
            {
                listBox.Items.Add("No hay notas para calcular.");
                return;
            }

            // Inicialización de variables
            int deficientes = 0;
            int aprobados = 0;
            double sumaNotas = 0;
            double notaMinima = notas[0];
            double notaMaxima = notas[0];

            // Recorrido de la lista de notas
            foreach (var nota in notas)
            {
                // Calcular deficientes (notas menores a 5.0)
                if (nota < 5.0)
                {
                    deficientes++;
                }

                // Calcular aprobados (notas mayores o iguales a 6.0)
                if (nota >= 6.0)
                {
                    aprobados++;
                }

                // Identificar nota más baja y más alta
                if (nota < notaMinima)
                {
                    notaMinima = nota;
                }
                if (nota > notaMaxima)
                {
                    notaMaxima = nota;
                }

                // Sumar todas las notas para calcular la media
                sumaNotas += nota;
            }

            // Calcular porcentaje de deficientes
            double porcentajeDeficientes = (double)deficientes / notas.Count * 100;

            // Calcular la nota media
            double notaMedia = sumaNotas / notas.Count;

            // Mostrar los resultados en el ListBox
            listBox.Items.Clear(); // Limpiar el ListBox
            listBox.Items.Add($"Porcentaje de estudiantes Deficientes (< 5.0): {porcentajeDeficientes:F2}%");
            listBox.Items.Add($"Número de aprobados: {aprobados}");
            listBox.Items.Add($"Nota más baja: {notaMinima:F2}");
            listBox.Items.Add($"Nota más alta: {notaMaxima:F2}");
            listBox.Items.Add($"Nota media del grupo: {notaMedia:F2}");
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Lista de ejemplo de notas
            List<double> notas = new List<double> { 8.5, 4.3, 6.0, 9.0, 5.5, 7.8, 2.4, 3.9, 10.0, 6.5 };

            // Llamar al método para calcular estadísticas y mostrar en el ListBox
            CalcularEstadisticas(notas, lstResultados);
        }
    }
}
