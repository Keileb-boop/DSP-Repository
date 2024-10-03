using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    class Cuenta
    {
        // Atributos
        private string numeroCuenta;
        private string dui;
        private double saldo;
        private double interesAnual;

        // Propiedades
        public string NumeroCuenta
        {
            get { return numeroCuenta; }
            private set { numeroCuenta = value; }
        }

        public string DUI
        {
            get { return dui; }
            set
            {
                // Validación básica del DUI
                if (!string.IsNullOrEmpty(value) && value.Length == 9)
                    dui = value;
                else
                    throw new ArgumentException("El DUI debe tener 9 caracteres.");
            }
        }

        public double Saldo
        {
            get { return saldo; }
            private set
            {
                if (value >= 0)
                    saldo = value;
                else
                    throw new ArgumentException("El saldo no puede ser negativo.");
            }
        }

        public double InteresAnual
        {
            get { return interesAnual; }
            set
            {
                // El interés debe estar entre el 10% y el 22.3%
                if (value >= 10 && value <= 22.3)
                    interesAnual = value;
                else
                    throw new ArgumentException("El interés anual debe estar entre 10% y 22.3%.");
            }
        }

        // Constructor
        public Cuenta(string dui, double saldoInicial, double interesAnual, int correlativo)
        {
            DUI = dui;
            Saldo = saldoInicial;
            InteresAnual = interesAnual;
            NumeroCuenta = GenerarNumeroCuenta(correlativo);
        }

        // Método para generar el número de cuenta en el formato DDMMYYYY-XXXXXX
        private string GenerarNumeroCuenta(int correlativo)
        {
            return DateTime.Now.ToString("ddMMyyyy") + "-" + correlativo.ToString("D6");
        }

        // Método para actualizar el saldo aplicando el interés diario
        public void ActualizarSaldo()
        {
            double interesDiario = (InteresAnual / 100) / 365;
            Saldo += Saldo * interesDiario;
        }

        // Método para ingresar dinero en la cuenta
        public void Ingresar(double cantidad)
        {
            if (cantidad > 0)
                Saldo += cantidad;
            else
                throw new ArgumentException("La cantidad a ingresar debe ser mayor a cero.");
        }

        // Método para retirar dinero de la cuenta
        public void Retirar(double cantidad)
        {
            if (cantidad > 0 && cantidad <= Saldo)
                Saldo -= cantidad;
            else
                throw new ArgumentException("Cantidad no válida para retirar o saldo insuficiente.");
        }

        // Método para mostrar los datos de la cuenta
        public string MostrarDatos()
        {
            return $"Número de Cuenta: {NumeroCuenta}\nDUI: {DUI}\nSaldo Actual: ${Saldo:F2}\nInterés Anual: {InteresAnual}%";
        }
    }
}

