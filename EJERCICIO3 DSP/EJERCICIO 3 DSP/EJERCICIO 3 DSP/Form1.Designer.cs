namespace EJERCICIO_3_DSP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btntarea = new Button();
            listBox1 = new ListBox();
            btneliminar = new Button();
            btneditar = new Button();
            btncomplet = new Button();
            btnsalir = new Button();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(153, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(406, 72);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btntarea
            // 
            btntarea.Location = new Point(100, 144);
            btntarea.Name = "btntarea";
            btntarea.Size = new Size(127, 29);
            btntarea.TabIndex = 2;
            btntarea.Text = "Agregar Tarea";
            btntarea.UseVisualStyleBackColor = true;
            btntarea.Click += btntarea_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(85, 179);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(304, 104);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(100, 289);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(126, 29);
            btneliminar.TabIndex = 4;
            btneliminar.Text = "Eliminar Tarea";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // btneditar
            // 
            btneditar.Location = new Point(251, 144);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(120, 29);
            btneditar.TabIndex = 5;
            btneditar.Text = "Editar Tarea";
            btneditar.UseVisualStyleBackColor = true;
            btneditar.Click += btneditar_Click;
            // 
            // btncomplet
            // 
            btncomplet.Location = new Point(251, 289);
            btncomplet.Name = "btncomplet";
            btncomplet.Size = new Size(126, 49);
            btncomplet.TabIndex = 6;
            btncomplet.Text = "Tarea completada";
            btncomplet.UseVisualStyleBackColor = true;
            btncomplet.Click += btncomplet_Click;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = SystemColors.Highlight;
            btnsalir.Location = new Point(552, 287);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(104, 31);
            btnsalir.TabIndex = 7;
            btnsalir.Text = "Salir";
            btnsalir.TextAlign = ContentAlignment.TopCenter;
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(429, 179);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(304, 104);
            listBox2.TabIndex = 8;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox2);
            Controls.Add(btnsalir);
            Controls.Add(btncomplet);
            Controls.Add(btneditar);
            Controls.Add(btneliminar);
            Controls.Add(listBox1);
            Controls.Add(btntarea);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Creador de Tareas :)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Button btntarea;
        private ListBox listBox1;
        private Button btneliminar;
        private Button btneditar;
        private Button btncomplet;
        private Button btnsalir;
        private ListBox listBox2;
    }
}
