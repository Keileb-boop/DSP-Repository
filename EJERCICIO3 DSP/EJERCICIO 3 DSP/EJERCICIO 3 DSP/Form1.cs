using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EJERCICIO_3_DSP
{
    public partial class Form1 : Form
    {
        private string textoCapturado;

        // esta es mi ruta donde se guarda el txt, modificarlo para que lo encuentre :)
        private string rutaArchivo = @"C:\Users\djcje\Desktop\EJERCICIO3 DSP\datos_tareas.txt";

        public Form1()
        {
            InitializeComponent();
            CargarDatos(); // carga los datos al iniciar el form
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Captura el texto actual del TextBox
            textoCapturado = textBox1.Text;
            Console.WriteLine("Texto ingresado: " + textoCapturado);
        }

        private void btntarea_Click(object sender, EventArgs e)
        {
            // Capturar el texto del TextBox
            string textoIngresado = textBox1.Text;

            // Capturar la fecha del DateTimePicker
            DateTime fechaSeleccionada = dateTimePicker1.Value;

            // verificav que el texto no esté vacío
            if (!string.IsNullOrWhiteSpace(textoIngresado))
            {
                
                string itemListBox = $"{textoIngresado} - {fechaSeleccionada.ToShortDateString()}";

                // Agregar la cadena al ListBox
                listBox1.Items.Add(itemListBox);

                // Limpiar el TextBox 
                textBox1.Clear();

                // Guardar los datos 
                GuardarDatos();
            }
            else
            {
                // Mostrar un mensaje si el TextBox está vacío
                MessageBox.Show("Por favor, ingrese un texto antes de agregarlo.");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            // Verificar que haya un ítem seleccionado en el ListBox
            if (listBox1.SelectedItem != null)
            {
                // Obtener el ítem seleccionado
                var itemSeleccionado = listBox1.SelectedItem;

                // Eliminar el ítem del ListBox
                listBox1.Items.Remove(itemSeleccionado);

                // Limpiar el TextBox y DateTimePicker
                textBox1.Clear();
                dateTimePicker1.Value = DateTime.Now;

               
                GuardarDatos();
            }
            else
            {
                // Mostrar un mensaje si no hay ítem seleccionado
                MessageBox.Show("Por favor, seleccione una tarea para eliminar.");
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            // Verificar que haya un ítem seleccionado en el ListBox
            if (listBox1.SelectedItem != null)
            {
                // Capturar el texto del TextBox y la fecha
                string nuevoTexto = textBox1.Text;
                DateTime nuevaFecha = dateTimePicker1.Value;

                // Verificar que el campo no esté vacío
                if (!string.IsNullOrWhiteSpace(nuevoTexto))
                {
                    // Crear una cadena que combine el texto y la fecha
                    string nuevoItemListBox = $"{nuevoTexto} - {nuevaFecha.ToShortDateString()}";

                    // Obtener el índice del ítem seleccionado
                    int indiceSeleccionado = listBox1.SelectedIndex;

                    // Actualizar la tarea
                    listBox1.Items[indiceSeleccionado] = nuevoItemListBox;

                    
                    GuardarDatos();
                }
                else
                {
                    // Mostrar un mensaje si el TextBox está vacío
                    MessageBox.Show("Por favor, ingrese un texto antes de editar.");
                }
            }
            else
            {
                // Mostrar un mensaje si no hay ítem seleccionado
                MessageBox.Show("Por favor, seleccione una tarea para editar.");
            }
        }

        private void btncomplet_Click(object sender, EventArgs e)
        {
            // Verificar que haya un ítem seleccionado en el ListBox1
            if (listBox1.SelectedItem != null)
            {
                // Obtener el ítem seleccionado
                var itemSeleccionado = listBox1.SelectedItem;

                // Agregar el ítem a ListBox2
                listBox2.Items.Add(itemSeleccionado);

                // Eliminar el ítem de ListBox1
                listBox1.Items.Remove(itemSeleccionado);

                // Limpiar el TextBox y DateTimePicker
                textBox1.Clear();
                dateTimePicker1.Value = DateTime.Now;

               
                GuardarDatos();
            }
            else
            {
                // Mostrar un mensaje si no hay ítem seleccionado
                MessageBox.Show("Por favor, seleccione una tarea para marcar como completada.");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedItem != null)
            {
                string texto = listBox1.SelectedItem.ToString();
                // Separar el texto y la fecha
                string[] partes = texto.Split(new[] { " - " }, StringSplitOptions.None);
                if (partes.Length == 2)
                {
                    textBox1.Text = partes[0];
                    dateTimePicker1.Value = DateTime.Parse(partes[1]);
                }
            }
        }

        private void GuardarDatos()
        {
            // Crear un archivo y escribir los datos del ListBox1
            using (StreamWriter escritor = new StreamWriter(rutaArchivo))
            {
                foreach (var item in listBox1.Items)
                {
                    escritor.WriteLine(item.ToString());
                }
            }
        }

        private void CargarDatos()
        {
            if (File.Exists(rutaArchivo))
            {
                using (StreamReader lector = new StreamReader(rutaArchivo))
                {
                    string linea;
                    while ((linea = lector.ReadLine()) != null)
                    {
                        listBox1.Items.Add(linea);
                    }
                }
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
