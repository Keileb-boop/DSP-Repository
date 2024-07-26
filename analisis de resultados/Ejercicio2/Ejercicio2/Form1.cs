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
            InitializeComboBoxes();
        }
        private void InitializeComboBoxes()
        {
            // Llenar ComboBox de Meses
            cbxMes.Items.AddRange(new string[] {
                "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
            });

            // Llenar ComboBox de Años 
            for (int year = 2000; year <= 2030; year++)
            {
                cbxAnio.Items.Add(year);
            }

            // Añadir evento para actualizar los días al seleccionar un mes
            cbxMes.SelectedIndexChanged += ComboBoxMes_SelectedIndexChanged;
        }

        private void ComboBoxMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Actualizar los días según el mes seleccionado
            UpdateDays();
        }

        private void UpdateDays()
        {
            if (cbxAnio.SelectedItem == null || cbxMes.SelectedItem == null) return;

            int year = (int)cbxAnio.SelectedItem;
            int month = cbxMes.SelectedIndex + 1;

            int daysInMonth = GetDaysInMonth(month, year);

            cbxDias.Items.Clear();
            for (int day = 1; day <= daysInMonth; day++)
            {
                cbxDias.Items.Add(day);
            }
        }

        private int GetDaysInMonth(int month, int year)
        {
            switch (month)
            {
                case 1: // Enero
                case 3: // Marzo
                case 5: // Mayo
                case 7: // Julio
                case 8: // Agosto
                case 10: // Octubre
                case 12: // Diciembre
                    return 31;
                case 4: // Abril
                case 6: // Junio
                case 9: // Septiembre
                case 11: // Noviembre
                    return 30;
                case 2: // Febrero
                    if (DateTime.IsLeapYear(year))
                        return 29;
                    else
                        return 28;
                default:
                    throw new ArgumentOutOfRangeException("Mes inválido");
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxDias.SelectedItem == null || cbxMes.SelectedItem == null || cbxAnio.SelectedItem == null)
                {
                    lblMensaje.Text = "Por favor, seleccione una fecha completa.";
                    return;
                }

                int day = (int)cbxDias.SelectedItem;
                int month = cbxMes.SelectedIndex + 1;
                int year = (int)cbxAnio.SelectedItem;

                DateTime selectedDate = new DateTime(year, month, day);
                lblMensaje.Text = $"Fecha válida: {selectedDate.ToString("MMMM dd, yyyy")}";
            }
            catch (Exception)
            {
                lblMensaje.Text = "Fecha inválida. Por favor, verifique los valores ingresados.";
            }
        }
    }
}

