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
    public partial class Form3 : Form
    {
        private string noms, ape1, ape2;
        private double CUM;
        private int UV;
        //valida que el dato recibido es un numero
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        //evalua el cum
        private void EvaluarCUM()
        {
            //una vez recibidos los nombres del estudiante, asi como su CUM se detemina las UV'  solicitadas
            string nombrecompleto;
            noms = txtNom.Text.Trim();
            ape1 = txtApe1.Text.Trim();
            ape2 = txtApe2.Text.Trim();
            string cumStr = txtCUM.Text.Trim();

            // Validaciones de los nombres
            if (string.IsNullOrEmpty(noms) || string.IsNullOrEmpty(ape1) || string.IsNullOrEmpty(ape2))
            {
                MessageBox.Show("Todos los campos de nombre son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de CUM
            if (!IsNumeric(cumStr) || !double.TryParse(cumStr, out CUM))
            {
                MessageBox.Show("El CUM debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCUM.Focus();
                return;
            }

            nombrecompleto = noms + " " + ape1 + " " + ape2;
            nombrecompleto = nombrecompleto.ToUpper();
            if (CUM < 0 | CUM > 10)
            {
                MessageBox.Show("Valor de CUM fuera de rango (0.0 - 10.0)", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCUM.Focus();
            }
            else
            {
                //Usa estructura switch
                switch (Convert.ToInt16(CUM))
                {
                    case 8 - 10:
                        UV = 32;
                        break;
                    case 7:
                        UV = 24;
                        break;
                    case 6:
                        UV = 20;
                        break;
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        UV = 16;
                        break;
                    default:
                        UV = 0;
                        break;
                }
                txtResul.Text = nombrecompleto + "Puede cursar " + UV + "UV";
            }

        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            EvaluarCUM();
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
