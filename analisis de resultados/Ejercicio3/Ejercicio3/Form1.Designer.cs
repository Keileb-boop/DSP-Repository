namespace Ejercicio3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lstNumPoitivos = new System.Windows.Forms.ListBox();
            this.lstNumNegativos = new System.Windows.Forms.ListBox();
            this.lblMinNegativo = new System.Windows.Forms.Label();
            this.lblPromNegativos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAgregar.Location = new System.Drawing.Point(365, 21);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(129, 50);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCalcular.Location = new System.Drawing.Point(195, 232);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(117, 54);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(195, 30);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 26);
            this.txtNum.TabIndex = 2;
            // 
            // lstNumPoitivos
            // 
            this.lstNumPoitivos.FormattingEnabled = true;
            this.lstNumPoitivos.ItemHeight = 20;
            this.lstNumPoitivos.Location = new System.Drawing.Point(67, 106);
            this.lstNumPoitivos.Name = "lstNumPoitivos";
            this.lstNumPoitivos.Size = new System.Drawing.Size(178, 104);
            this.lstNumPoitivos.TabIndex = 3;
            // 
            // lstNumNegativos
            // 
            this.lstNumNegativos.FormattingEnabled = true;
            this.lstNumNegativos.ItemHeight = 20;
            this.lstNumNegativos.Location = new System.Drawing.Point(277, 106);
            this.lstNumNegativos.Name = "lstNumNegativos";
            this.lstNumNegativos.Size = new System.Drawing.Size(181, 104);
            this.lstNumNegativos.TabIndex = 4;
            this.lstNumNegativos.SelectedIndexChanged += new System.EventHandler(this.lstNumNegativos_SelectedIndexChanged);
            // 
            // lblMinNegativo
            // 
            this.lblMinNegativo.AutoSize = true;
            this.lblMinNegativo.Location = new System.Drawing.Point(83, 315);
            this.lblMinNegativo.Name = "lblMinNegativo";
            this.lblMinNegativo.Size = new System.Drawing.Size(104, 20);
            this.lblMinNegativo.TabIndex = 5;
            this.lblMinNegativo.Text = "Min Negativo:";
            // 
            // lblPromNegativos
            // 
            this.lblPromNegativos.AutoSize = true;
            this.lblPromNegativos.Location = new System.Drawing.Point(302, 315);
            this.lblPromNegativos.Name = "lblPromNegativos";
            this.lblPromNegativos.Size = new System.Drawing.Size(145, 20);
            this.lblPromNegativos.TabIndex = 6;
            this.lblPromNegativos.Text = "Promedio positivos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Agrega valores:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPromNegativos);
            this.Controls.Add(this.lblMinNegativo);
            this.Controls.Add(this.lstNumNegativos);
            this.Controls.Add(this.lstNumPoitivos);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Ejercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ListBox lstNumPoitivos;
        private System.Windows.Forms.ListBox lstNumNegativos;
        private System.Windows.Forms.Label lblMinNegativo;
        private System.Windows.Forms.Label lblPromNegativos;
        private System.Windows.Forms.Label label1;
    }
}

