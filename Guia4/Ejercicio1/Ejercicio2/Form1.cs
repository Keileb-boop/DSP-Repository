using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Método para generar la matriz  con números aleatorios
        private int[,] GenerarMatriz(int limiteInferior, int limiteSuperior)
        {
            Random random = new Random();
            int[,] matriz = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    // Genera un número aleatorio entre los límites dados
                    matriz[i, j] = random.Next(limiteInferior, limiteSuperior + 1);
                }
            }

            return matriz;
        }

        // Método para mostrar la matriz en un DataGridView
        private void MostrarMatrizEnDataGridView(int[,] matriz, DataGridView dataGridView)
        {
            // Limpia cualquier contenido previo en el DataGridView
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            // Configura las columnas del DataGridView
            for (int i = 0; i < 5; i++)
            {
                dataGridView.Columns.Add($"Columna{i + 1}", $"Columna {i + 1}");
            }

            // Añade las filas con los valores de la matriz
            for (int i = 0; i < 5; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView);

                for (int j = 0; j < 5; j++)
                {
                    row.Cells[j].Value = matriz[i, j];
                }

                dataGridView.Rows.Add(row);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Establecer los límites
            int limiteInferior = 10; 
            int limiteSuperior = 100; 

            // Generar la matriz
            int[,] matriz = GenerarMatriz(limiteInferior, limiteSuperior);

            // Mostrar la matriz en el DataGridView
            MostrarMatrizEnDataGridView(matriz, dataGridView1);
        }
    }
}
