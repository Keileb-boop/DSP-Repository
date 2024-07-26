using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        private string mensa;
        private static int conta; // Declarar variable: conta, tipo int de alcance privado

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Evento se ejecuta al iniciar ejecución de Form1
            mensa = "Aun no ha presionado botón Contar";
            label1.Text = mensa;
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            //Acumulador, Total veces que presiona botón
            //int conta = 0;
            //conta+=1; //En forma de operador abreviado
            conta = conta + 1;
            
            mensa = "Presiono botón Contar, un total de" + Convert.ToString(conta) + " veces"; //convert me pase mi variable conta de int a string
            label1.Text = mensa;
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            //Restaura conteo clic realizado a button1
            conta =0;
            mensa = "Presiono boton Contar, un total de" + Convert.ToString(conta) + " veces";
            label1.Text = mensa;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();//finaliza la aplicación
        }
    }
}
