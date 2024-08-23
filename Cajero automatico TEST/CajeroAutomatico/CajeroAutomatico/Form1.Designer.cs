namespace CajeroAutomatico
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
            labelinicial = new Label();
            botoncont = new Button();
            textBox1 = new TextBox();
            botoncuenta = new Button();
            label2 = new Label();
            lblbienvenido = new Label();
            saldo = new Button();
            fondos = new Button();
            Cosignacion = new Button();
            transferir = new Button();
            exit = new Button();
            salir1 = new Button();
            salir2 = new Button();
            salirtexto = new Label();
            saldoconsult = new Label();
            textodeco = new Label();
            textBox2 = new TextBox();
            btnretirar = new Button();
            retiroexit = new Label();
            regresarbtn = new Button();
            consglbl = new Label();
            consigbtn = new Button();
            label1 = new Label();
            regresarbtn2 = new Button();
            transferlbl = new Label();
            transferbtn = new Button();
            consignacionbtn = new TextBox();
            transfertxt = new TextBox();
            numerocuenta = new Label();
            textotransfer = new TextBox();
            cuentadif = new Button();
            SuspendLayout();
            // 
            // labelinicial
            // 
            labelinicial.AutoSize = true;
            labelinicial.Location = new Point(226, 56);
            labelinicial.Name = "labelinicial";
            labelinicial.Size = new Size(260, 20);
            labelinicial.TabIndex = 0;
            labelinicial.Text = "Bienvenido, porfavor inserte su tarjeta";
            labelinicial.Click += labelinicial_Click;
            // 
            // botoncont
            // 
            botoncont.Location = new Point(302, 95);
            botoncont.Name = "botoncont";
            botoncont.Size = new Size(94, 29);
            botoncont.TabIndex = 1;
            botoncont.Text = "Continuar";
            botoncont.UseVisualStyleBackColor = true;
            botoncont.Click += botoncont_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(226, 185);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // botoncuenta
            // 
            botoncuenta.Location = new Point(379, 185);
            botoncuenta.Name = "botoncuenta";
            botoncuenta.Size = new Size(94, 29);
            botoncuenta.TabIndex = 3;
            botoncuenta.Text = "Ingresar";
            botoncuenta.UseVisualStyleBackColor = true;
            botoncuenta.Click += botoncuenta_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 142);
            label2.Name = "label2";
            label2.Size = new Size(165, 20);
            label2.TabIndex = 4;
            label2.Text = "Ingrese su N° de cuenta";
            // 
            // lblbienvenido
            // 
            lblbienvenido.AutoSize = true;
            lblbienvenido.Location = new Point(166, 152);
            lblbienvenido.Name = "lblbienvenido";
            lblbienvenido.Size = new Size(83, 20);
            lblbienvenido.TabIndex = 5;
            lblbienvenido.Text = "Bienvenido";
            lblbienvenido.Click += lblbienvenido_Click;
            // 
            // saldo
            // 
            saldo.Location = new Point(166, 185);
            saldo.Name = "saldo";
            saldo.Size = new Size(166, 29);
            saldo.TabIndex = 6;
            saldo.Text = "Consultar saldo";
            saldo.UseVisualStyleBackColor = true;
            saldo.Click += saldo_Click;
            // 
            // fondos
            // 
            fondos.Location = new Point(166, 230);
            fondos.Name = "fondos";
            fondos.Size = new Size(166, 29);
            fondos.TabIndex = 7;
            fondos.Text = "Retiro de fondos";
            fondos.UseVisualStyleBackColor = true;
            fondos.Click += fondos_Click;
            // 
            // Cosignacion
            // 
            Cosignacion.Location = new Point(166, 277);
            Cosignacion.Name = "Cosignacion";
            Cosignacion.Size = new Size(166, 29);
            Cosignacion.TabIndex = 8;
            Cosignacion.Text = "Consignaciones";
            Cosignacion.UseVisualStyleBackColor = true;
            Cosignacion.Click += Cosignacion_Click;
            // 
            // transferir
            // 
            transferir.Location = new Point(166, 325);
            transferir.Name = "transferir";
            transferir.Size = new Size(166, 29);
            transferir.TabIndex = 9;
            transferir.Text = "Transferencias";
            transferir.UseVisualStyleBackColor = true;
            transferir.Click += transferir_Click;
            // 
            // exit
            // 
            exit.BackColor = Color.LightCoral;
            exit.Location = new Point(201, 371);
            exit.Name = "exit";
            exit.Size = new Size(96, 29);
            exit.TabIndex = 10;
            exit.Text = "Salir";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // salir1
            // 
            salir1.Location = new Point(238, 277);
            salir1.Name = "salir1";
            salir1.Size = new Size(94, 29);
            salir1.TabIndex = 11;
            salir1.Text = "Salir";
            salir1.UseVisualStyleBackColor = true;
            salir1.Click += salir1_Click;
            // 
            // salir2
            // 
            salir2.Location = new Point(379, 277);
            salir2.Name = "salir2";
            salir2.Size = new Size(94, 29);
            salir2.TabIndex = 12;
            salir2.Text = "No";
            salir2.UseVisualStyleBackColor = true;
            salir2.Click += salir2_Click;
            // 
            // salirtexto
            // 
            salirtexto.AutoSize = true;
            salirtexto.Location = new Point(302, 239);
            salirtexto.Name = "salirtexto";
            salirtexto.Size = new Size(95, 20);
            salirtexto.TabIndex = 13;
            salirtexto.Text = "¿Desea salir?";
            salirtexto.Click += salirtexto_Click;
            // 
            // saldoconsult
            // 
            saldoconsult.AutoSize = true;
            saldoconsult.Location = new Point(384, 189);
            saldoconsult.Name = "saldoconsult";
            saldoconsult.Size = new Size(50, 20);
            saldoconsult.TabIndex = 14;
            saldoconsult.Text = "label1";
            saldoconsult.Click += saldoconsult_Click;
            // 
            // textodeco
            // 
            textodeco.AutoSize = true;
            textodeco.Location = new Point(420, 189);
            textodeco.Name = "textodeco";
            textodeco.Size = new Size(157, 20);
            textodeco.TabIndex = 15;
            textodeco.Text = "¿Cuanto desea retirar?";
            textodeco.Click += textodeco_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(429, 244);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 16;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btnretirar
            // 
            btnretirar.Location = new Point(441, 277);
            btnretirar.Name = "btnretirar";
            btnretirar.Size = new Size(94, 29);
            btnretirar.TabIndex = 17;
            btnretirar.Text = "Retirar";
            btnretirar.UseVisualStyleBackColor = true;
            btnretirar.Click += btnretirar_Click;
            // 
            // retiroexit
            // 
            retiroexit.AutoSize = true;
            retiroexit.Location = new Point(292, 122);
            retiroexit.Name = "retiroexit";
            retiroexit.Size = new Size(117, 20);
            retiroexit.TabIndex = 18;
            retiroexit.Text = "¡¡Retiro exitoso!!";
            retiroexit.Click += retiroexit_Click;
            // 
            // regresarbtn
            // 
            regresarbtn.Location = new Point(302, 165);
            regresarbtn.Name = "regresarbtn";
            regresarbtn.Size = new Size(94, 29);
            regresarbtn.TabIndex = 19;
            regresarbtn.Text = "Regresar";
            regresarbtn.UseVisualStyleBackColor = true;
            regresarbtn.Click += regresarbtn_Click;
            // 
            // consglbl
            // 
            consglbl.AutoSize = true;
            consglbl.Location = new Point(420, 254);
            consglbl.Name = "consglbl";
            consglbl.Size = new Size(181, 20);
            consglbl.TabIndex = 21;
            consglbl.Text = "¿Cuanto desea consignar?";
            consglbl.Click += consglbl_Click;
            // 
            // consigbtn
            // 
            consigbtn.Location = new Point(441, 325);
            consigbtn.Name = "consigbtn";
            consigbtn.Size = new Size(94, 29);
            consigbtn.TabIndex = 22;
            consigbtn.Text = "Consignar";
            consigbtn.UseVisualStyleBackColor = true;
            consigbtn.Click += consigbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 104);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 23;
            label1.Text = "¡¡Consignacion exitosa!!";
            label1.Click += label1_Click;
            // 
            // regresarbtn2
            // 
            regresarbtn2.Location = new Point(302, 138);
            regresarbtn2.Name = "regresarbtn2";
            regresarbtn2.Size = new Size(94, 29);
            regresarbtn2.TabIndex = 24;
            regresarbtn2.Text = "Regresar";
            regresarbtn2.UseVisualStyleBackColor = true;
            regresarbtn2.Click += regresarbtn2_Click;
            // 
            // transferlbl
            // 
            transferlbl.AutoSize = true;
            transferlbl.Location = new Point(475, 152);
            transferlbl.Name = "transferlbl";
            transferlbl.Size = new Size(176, 20);
            transferlbl.TabIndex = 25;
            transferlbl.Text = "¿Cuanto desea transferir?";
            transferlbl.Click += transferlbl_Click;
            // 
            // transferbtn
            // 
            transferbtn.Location = new Point(516, 290);
            transferbtn.Name = "transferbtn";
            transferbtn.Size = new Size(94, 29);
            transferbtn.TabIndex = 26;
            transferbtn.Text = "Transferir";
            transferbtn.UseVisualStyleBackColor = true;
            transferbtn.Click += transferbtn_Click;
            // 
            // consignacionbtn
            // 
            consignacionbtn.Location = new Point(429, 292);
            consignacionbtn.Name = "consignacionbtn";
            consignacionbtn.Size = new Size(125, 27);
            consignacionbtn.TabIndex = 20;
            consignacionbtn.TextChanged += consignacionbtn_TextChanged;
            // 
            // transfertxt
            // 
            transfertxt.Location = new Point(507, 175);
            transfertxt.Name = "transfertxt";
            transfertxt.Size = new Size(125, 27);
            transfertxt.TabIndex = 27;
            transfertxt.TextChanged += transfertxt_TextChanged;
            // 
            // numerocuenta
            // 
            numerocuenta.AutoSize = true;
            numerocuenta.Location = new Point(507, 221);
            numerocuenta.Name = "numerocuenta";
            numerocuenta.Size = new Size(112, 20);
            numerocuenta.TabIndex = 28;
            numerocuenta.Text = "¿A cual cuenta?";
            numerocuenta.Click += numerocuenta_Click;
            // 
            // textotransfer
            // 
            textotransfer.Location = new Point(507, 251);
            textotransfer.Name = "textotransfer";
            textotransfer.Size = new Size(125, 27);
            textotransfer.TabIndex = 29;
            textotransfer.TextChanged += textotransfer_TextChanged;
            // 
            // cuentadif
            // 
            cuentadif.BackColor = Color.LightCoral;
            cuentadif.Location = new Point(377, 371);
            cuentadif.Name = "cuentadif";
            cuentadif.Size = new Size(158, 29);
            cuentadif.TabIndex = 30;
            cuentadif.Text = "Salir de la cuenta";
            cuentadif.UseVisualStyleBackColor = false;
            cuentadif.Click += cuentadif_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 485);
            Controls.Add(cuentadif);
            Controls.Add(textotransfer);
            Controls.Add(numerocuenta);
            Controls.Add(transfertxt);
            Controls.Add(transferbtn);
            Controls.Add(transferlbl);
            Controls.Add(regresarbtn2);
            Controls.Add(label1);
            Controls.Add(consigbtn);
            Controls.Add(consglbl);
            Controls.Add(consignacionbtn);
            Controls.Add(regresarbtn);
            Controls.Add(retiroexit);
            Controls.Add(btnretirar);
            Controls.Add(textBox2);
            Controls.Add(textodeco);
            Controls.Add(saldoconsult);
            Controls.Add(salirtexto);
            Controls.Add(salir2);
            Controls.Add(salir1);
            Controls.Add(exit);
            Controls.Add(transferir);
            Controls.Add(Cosignacion);
            Controls.Add(fondos);
            Controls.Add(saldo);
            Controls.Add(lblbienvenido);
            Controls.Add(label2);
            Controls.Add(botoncuenta);
            Controls.Add(textBox1);
            Controls.Add(botoncont);
            Controls.Add(labelinicial);
            Name = "Form1";
            Text = "Cuenta bancaria";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelinicial;
        private Button botoncont;
        private TextBox textBox1;
        private Button botoncuenta;
        private Label label2;
        private Label lblbienvenido;
        private Button saldo;
        private Button fondos;
        private Button Cosignacion;
        private Button transferir;
        private Button exit;
        private Button salir1;
        private Button salir2;
        private Label salirtexto;
        private Label saldoconsult;
        private Label textodeco;
        private TextBox textBox2;
        private Button btnretirar;
        private Label retiroexit;
        private Button regresarbtn;
        private Label consglbl;
        private Button consigbtn;
        private Label label1;
        private Button regresarbtn2;
        private Label transferlbl;
        private Button transferbtn;
        private TextBox consignacionbtn;
        private TextBox transfertxt;
        private Label numerocuenta;
        private TextBox textotransfer;
        private Button cuentadif;
    }
}
