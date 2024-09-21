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
        private int[] lista; // Variable que almacenará el arreglo que simula la lista.
    
        public Form1()
        {
            InitializeComponent();
        }

        // a) Crear lista vacía
        //Este método inicializa el arreglo con una longitud de 0 para simular una lista vacía.
        private void CrearListaVacia(ref int[] lista)
        {
            lista = new int[0]; // Crear una lista (arreglo) vacía.
        }

        // b) Mostrar listado de elementos de la lista en el ListBox
        private void MostrarElementos(int[] lista, ListBox listBox)
        {
            listBox.Items.Clear(); // Limpiar ListBox antes de mostrar los elementos.
            foreach (int elemento in lista)
            {
                listBox.Items.Add(elemento); // Añadir cada elemento de la lista al ListBox.
            }
        }

        // c) Insertar elemento en la lista
        private void InsertarElemento(ref int[] lista, int nuevoElemento)
        {
            int[] nuevaLista = new int[lista.Length + 1]; // Crear un nuevo arreglo con un tamaño mayor.
            for (int i = 0; i < lista.Length; i++)
            {
                nuevaLista[i] = lista[i]; // Copiar los elementos actuales.
            }
            nuevaLista[nuevaLista.Length - 1] = nuevoElemento; // Añadir el nuevo elemento al final.
            lista = nuevaLista; // Asignar la nueva lista al arreglo original.
        }

        // d) Remover primer elemento de la lista
        private void RemoverElemento(ref int[] lista)
        {
            if (lista.Length > 0)
            {
                int[] nuevaLista = new int[lista.Length - 1]; // Crear un nuevo arreglo con un tamaño menor.
                for (int i = 1; i < lista.Length; i++)
                {
                    nuevaLista[i - 1] = lista[i]; // Copiar todos los elementos excepto el primero.
                }
                lista = nuevaLista; // Asignar la nueva lista al arreglo original.
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListaVacia_Click(object sender, EventArgs e)
        {
            CrearListaVacia(ref lista); // Llamar al método para crear la lista vacía.
            MessageBox.Show("Lista vacía creada.");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarElementos(lista, lstElementos); // Llamar al método para mostrar los elementos en el ListBox.
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtElemento.Text, out int nuevoElemento))
            {
                InsertarElemento(ref lista, nuevoElemento); // Llamar al método para insertar un nuevo elemento.
                MessageBox.Show($"Elemento {nuevoElemento} agregado.");
                txtElemento.Clear(); // Limpiar el campo de texto.
                MostrarElementos(lista, lstElementos); // Mostrar los elementos actualizados.
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lista.Length > 0)
            {
                RemoverElemento(ref lista); // Llamar al método para remover el primer elemento.
                MessageBox.Show("Primer elemento removido.");
                MostrarElementos(lista, lstElementos); // Mostrar los elementos actualizados.
            }
            else
            {
                MessageBox.Show("No hay elementos para remover.");
            }
        }
    }
}
