using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuenta
{
    public partial class Form1 : Form
    {
        private List<Cuenta> cuentas = new List<Cuenta>();
        private int correlativo = 1000001;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                string dui = txtDUI.Text;
                double saldoInicial = Convert.ToDouble(txtSaldoInicial.Text);
                double interesAnual = Convert.ToDouble(txtInteresAnual.Text);

                Cuenta nuevaCuenta = new Cuenta(dui, saldoInicial, interesAnual, correlativo);
                cuentas.Add(nuevaCuenta);
                correlativo++;

                MessageBox.Show("Cuenta creada exitosamente.\n" + nuevaCuenta.MostrarDatos());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string numeroCuenta = txtNumCuenta.Text;
                double cantidad = Convert.ToDouble(txtCuenta.Text);

                Cuenta cuenta = BuscarCuenta(numeroCuenta);
                if (cuenta != null)
                {
                    cuenta.Ingresar(cantidad);
                    MessageBox.Show("Ingreso exitoso.\nSaldo actual: $" + cuenta.Saldo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            try
            {
                string numeroCuenta = txtNumCuenta.Text;
                double cantidad = Convert.ToDouble(txtCuenta.Text);

                Cuenta cuenta = BuscarCuenta(numeroCuenta);
                if (cuenta != null)
                {
                    cuenta.Retirar(cantidad);
                    MessageBox.Show("Retiro exitoso.\nSaldo actual: $" + cuenta.Saldo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                string numeroCuenta = txtNumCuenta.Text;
                Cuenta cuenta = BuscarCuenta(numeroCuenta);

                if (cuenta != null)
                {
                    MessageBox.Show(cuenta.MostrarDatos());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        // Buscar cuenta por número
        private Cuenta BuscarCuenta(string numeroCuenta)
        {
            foreach (Cuenta cuenta in cuentas)
            {
                if (cuenta.NumeroCuenta == numeroCuenta)
                {
                    return cuenta;
                }
            }
            MessageBox.Show("Cuenta no encontrada.");
            return null;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            string numeroCuenta = txtNumCuenta.Text;
            Cuenta cuenta = BuscarCuenta(numeroCuenta);
            if (cuenta != null)
            {
                cuentas.Remove(cuenta);
                MessageBox.Show("Cuenta cerrada exitosamente.");
            }
        }
    }
 }
 
    
    


