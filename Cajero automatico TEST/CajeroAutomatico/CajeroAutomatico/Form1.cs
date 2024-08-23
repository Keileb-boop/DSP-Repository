namespace CajeroAutomatico
{
    public partial class Form1 : Form
    {

        private readonly Dictionary<int, decimal> accountBalances = new Dictionary<int, decimal>
        {
            { 1000001, 400 },
            { 1000002, 200 },
            { 1000004, 500 }
        };

        private decimal dinerodecuenta;
        private decimal Depositocuenta;
        private decimal amountToTransfer;
        private int? targetAccountNumber;




        public Form1()
        {

            //mont�n de instrucciones xd
            //es para que se vayan ocultando los controles que no se est�n usando 
            //y se activen en cada cosa requerida :D

            InitializeComponent();
            textBox1.Visible = false;
            botoncuenta.Visible = false;
            label2.Visible = false;
            lblbienvenido.Visible = false;
            saldo.Visible = false;
            Cosignacion.Visible = false;
            transferir.Visible = false;
            fondos.Visible = false;
            exit.Visible = false;
            salirtexto.Visible = false;
            salir1.Visible = false;
            salir2.Visible = false;
            saldoconsult.Visible = false;
            textodeco.Visible = false;
            textBox2.Visible = false;
            btnretirar.Visible = false;
            retiroexit.Visible = false;
            regresarbtn.Visible = false;
            consignacionbtn.Visible = false;
            consglbl.Visible = false;
            consigbtn.Visible = false;
            label1.Visible = false;
            regresarbtn2.Visible = false;
            transferlbl.Visible = false;
            transferbtn.Visible = false;
            transfertxt.Visible = false;
            numerocuenta.Visible = false;
            textotransfer.Visible = false;
            cuentadif.Visible = false;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botoncont_Click(object sender, EventArgs e)
        {

            botoncont.Visible = false;
            labelinicial.Visible = false;
            label2.Visible = true;
            textBox1.Visible = true;
            botoncuenta.Visible = true;

        }

        private void labelinicial_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {




        }

        private void botoncuenta_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int accountNumber))
            {
                if (accountBalances.ContainsKey(accountNumber))
                {
                    label2.Visible = false;  // Oculta el mensaje de "Ingrese su n�mero de cuenta"
                    lblbienvenido.Visible = true;
                    saldo.Visible = true;
                    Cosignacion.Visible = true;
                    transferir.Visible = true;
                    fondos.Visible = true;
                    textBox1.Visible = false;
                    botoncuenta.Visible = false;
                    exit.Visible = true;
                    cuentadif.Visible = true;
                    saldoconsult.Visible = false; // muestra el saldo

                }
                else
                {
                    // Mensaje si la cuenta es inv�lida
                    MessageBox.Show("N�mero de cuenta inv�lido. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mensaje si el input no es un n�mero v�lido
                MessageBox.Show("Por favor, ingrese un n�mero de cuenta v�lido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblbienvenido_Click(object sender, EventArgs e)
        {

        }

        private void saldo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int accountNumber) && accountBalances.ContainsKey(accountNumber))
            {
                decimal balance = accountBalances[accountNumber];
                saldoconsult.Visible = true;
                textodeco.Visible = false;
                textBox2.Visible = false;
                btnretirar.Visible = false;
                retiroexit.Visible = false;
                regresarbtn.Visible = false;
                consignacionbtn.Visible = false;
                consigbtn.Visible = false;
                consglbl.Visible = false;
                transferlbl.Visible = false;
                transferbtn.Visible = false;
                transfertxt.Visible = false;
                numerocuenta.Visible = false;
                textotransfer.Visible = false;
                saldoconsult.Text = $"El saldo actual de la cuenta {accountNumber} es de: ${balance}";
            }

        }

        private void Cosignacion_Click(object sender, EventArgs e)
        {
            saldoconsult.Visible = false;
            consignacionbtn.Visible = true;
            consglbl.Visible = true;
            textodeco.Visible = false;
            textBox2.Visible = false;
            btnretirar.Visible = false;
            consigbtn.Visible = true;
            transferlbl.Visible = false;
            transferbtn.Visible = false;
            transfertxt.Visible = false;
            numerocuenta.Visible = false;
            textotransfer.Visible = false;
        }

        private void transferir_Click(object sender, EventArgs e)
        {
            transfertxt.Visible = true;
            transferlbl.Visible = true;
            transferbtn.Visible = true;
            textodeco.Visible = false;
            consglbl.Visible = false;
            btnretirar.Visible = false;
            textBox2.Visible = false;
            consigbtn.Visible = false;
            consignacionbtn.Visible = false;
            saldoconsult.Visible = false;
            numerocuenta.Visible = true;
            textotransfer.Visible = true;

        }

        private void fondos_Click(object sender, EventArgs e)
        {
            textodeco.Visible = true;
            textBox2.Visible = true;
            btnretirar.Visible = true;
            saldoconsult.Visible = false;
            regresarbtn.Visible = false;
            retiroexit.Visible = false;
            consignacionbtn.Visible = false;
            consglbl.Visible = false;
            consigbtn.Visible = false;
            transferlbl.Visible = false;
            transferbtn.Visible = false;
            transfertxt.Visible = false;
            numerocuenta.Visible = false;
            textotransfer.Visible = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            lblbienvenido.Visible = false;
            saldo.Visible = false;
            Cosignacion.Visible = false;
            transferir.Visible = false;
            fondos.Visible = false;
            exit.Visible = false;
            textodeco.Visible = false;
            textBox2.Visible = false;
            btnretirar.Visible = false;
            saldoconsult.Visible = false;
            salirtexto.Visible = true;
            salir1.Visible = true;
            salir2.Visible = true;
            consignacionbtn.Visible = false;
            consglbl.Visible = false;
            consigbtn.Visible = false;
            transferlbl.Visible = false;
            transferbtn.Visible = false;
            transfertxt.Visible = false;
            cuentadif.Visible = false;
        }

        private void salirtexto_Click(object sender, EventArgs e)
        {

        }

        private void salir1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salir2_Click(object sender, EventArgs e)
        {
            lblbienvenido.Visible = true;
            saldo.Visible = true;
            Cosignacion.Visible = true;
            transferir.Visible = true;
            fondos.Visible = true;
            exit.Visible = true;
            salirtexto.Visible = false;
            salir1.Visible = false;
            salir2.Visible = false;
            cuentadif.Visible=true;   
        }

        private void saldoconsult_Click(object sender, EventArgs e)
        {

        }

        private void textodeco_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // a numero decimal lo de la caja de texto
            if (decimal.TryParse(textBox2.Text, out decimal amount))
            {
                dinerodecuenta = amount;

            }
            else
            {
                // no agarra si no es un numero
                dinerodecuenta = 0;
                MessageBox.Show("Por favor, ingrese una cantidad v�lida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnretirar_Click(object sender, EventArgs e)
        {
            // Vsi la cuenta es valida y si existe
            if (int.TryParse(textBox1.Text, out int accountNumber) && accountBalances.ContainsKey(accountNumber))
            {
                decimal currentBalance = accountBalances[accountNumber];

                // revisa el dinero de la cuenta a ver si es suficiente
                if (dinerodecuenta > 0 && currentBalance >= dinerodecuenta)
                {
                    // resta la cantidad de dinero de la cuenta
                    accountBalances[accountNumber] -= dinerodecuenta;
                    btnretirar.Visible = false;
                    textBox2.Visible = false;
                    textodeco.Visible = false;
                    fondos.Visible = false;
                    transferir.Visible = false;
                    Cosignacion.Visible = false;
                    saldo.Visible = false;
                    exit.Visible = false;
                    cuentadif.Visible = false;
                    lblbienvenido.Visible = false;
                    regresarbtn.Visible = true;
                    retiroexit.Visible = true;

                    // Actualiza el saldo mostrado en el label
                    saldoconsult.Text = $"Retiro exitoso. El saldo restante de la cuenta {accountNumber} es de: ${accountBalances[accountNumber]}";
                }
                else if (dinerodecuenta > currentBalance)
                {
                    MessageBox.Show("Fondos insuficientes para completar la transacci�n.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingrese una cantidad v�lida para retirar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                saldoconsult.Text = "Error: No se ha seleccionado una cuenta v�lida.";
            }
        }

        private void retiroexit_Click(object sender, EventArgs e)
        {

        }

        private void regresarbtn_Click(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textodeco.Visible = false;
            btnretirar.Visible = false;
            fondos.Visible = true;
            transferir.Visible = true;
            Cosignacion.Visible = true;
            saldo.Visible = true;
            exit.Visible = true;
            lblbienvenido.Visible = true;
            retiroexit.Visible = false;
            regresarbtn.Visible = false;
            cuentadif.Visible = true;
        }

        private void consignacionbtn_TextChanged(object sender, EventArgs e)
        {
            // Intenta convertir el texto ingresado en un n�mero decimal
            if (decimal.TryParse(consignacionbtn.Text, out decimal amount))
            {
                Depositocuenta = amount;
            }
            else
            {
                // Si la conversi�n falla, resetea amountToDeposit
                Depositocuenta = 0;
                MessageBox.Show("Por favor, ingrese una cantidad v�lida para consignar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void consglbl_Click(object sender, EventArgs e)
        {

        }

        private void consigbtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int accountNumber) && accountBalances.ContainsKey(accountNumber))
            {
                if (Depositocuenta > 0)
                {
                    // Suma la cantidad depositada al saldo de la cuenta                
                    saldoconsult.Visible = false;
                    textodeco.Visible = false;
                    accountBalances[accountNumber] += Depositocuenta;
                    saldoconsult.Visible = false;
                    lblbienvenido.Visible = false;
                    exit.Visible = false;
                    transferir.Visible = false;
                    Cosignacion.Visible = false;
                    saldo.Visible = false;
                    fondos.Visible = false;
                    consigbtn.Visible = false;
                    consignacionbtn.Visible = false;
                    consglbl.Visible = false;
                    cuentadif.Visible = false;
                    label1.Visible = true;
                    regresarbtn2.Visible = true;
                    // Actualiza el saldo mostrado en el label

                }
                else
                {
                    MessageBox.Show("Ingrese una cantidad v�lida para consignar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                saldoconsult.Text = "Error: No se ha seleccionado una cuenta v�lida.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void regresarbtn2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            exit.Visible = true;
            transferir.Visible = true;
            Cosignacion.Visible = true;
            saldo.Visible = true;
            fondos.Visible = true;
            consigbtn.Visible = false;
            label1.Visible = false;
            regresarbtn2.Visible = false;
            lblbienvenido.Visible = true;
            cuentadif.Visible = true;

        }

        private void transferlbl_Click(object sender, EventArgs e)
        {

        }

        private void transferbtn_Click(object sender, EventArgs e)
        {
            // Verifica si se ingres� un n�mero de cuenta v�lido para la cuenta destino
            if (targetAccountNumber.HasValue && accountBalances.ContainsKey(targetAccountNumber.Value))
            {
                // Verifica si se ingres� una cantidad v�lida para transferir
                if (amountToTransfer > 0)
                {
                    // Verifica que la cuenta de origen tenga suficientes fondos
                    if (int.TryParse(textBox1.Text, out int sourceAccountNumber) && accountBalances.ContainsKey(sourceAccountNumber))
                    {
                        decimal currentBalance = accountBalances[sourceAccountNumber];

                        if (currentBalance >= amountToTransfer)
                        {
                            // Resta la cantidad de la cuenta de origen
                            accountBalances[sourceAccountNumber] -= amountToTransfer;

                            // Suma la cantidad a la cuenta destino
                            accountBalances[targetAccountNumber.Value] += amountToTransfer;

                            // Muestra un mensaje de �xito
                            MessageBox.Show($"Transferencia exitosa. Se han transferido ${amountToTransfer} de la cuenta {sourceAccountNumber} a la cuenta {targetAccountNumber.Value}.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Fondos insuficientes en la cuenta de origen para completar la transferencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("N�mero de cuenta de origen inv�lido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese una cantidad v�lida para transferir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("N�mero de cuenta destino inv�lido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void transfertxt_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(transfertxt.Text, out decimal amount))
            {
                amountToTransfer = amount;
            }
            else
            {
                amountToTransfer = 0;
                MessageBox.Show("Por favor, ingrese una cantidad v�lida en d�lares.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numerocuenta_Click(object sender, EventArgs e)
        {

        }

        private void textotransfer_TextChanged(object sender, EventArgs e)
        {
            // Intenta convertir el texto ingresado en un n�mero entero y lo almacena
            if (int.TryParse(textotransfer.Text, out int accountNumber))
            {
                targetAccountNumber = accountNumber;
            }
            else
            {
                targetAccountNumber = null;
            }

        }

        private void cuentadif_Click(object sender, EventArgs e)
        {

            // mas mont�n de cosas
            lblbienvenido.Visible = false;
            saldo.Visible = false;
            Cosignacion.Visible = false;
            transferir.Visible = false;
            fondos.Visible = false;
            exit.Visible = false;
            saldoconsult.Visible = false;
            textodeco.Visible = false;
            textBox2.Visible = false;
            btnretirar.Visible = false;
            retiroexit.Visible = false;
            regresarbtn.Visible = false;
            consignacionbtn.Visible = false;
            consglbl.Visible = false;
            consigbtn.Visible = false;
            label1.Visible = false;
            regresarbtn2.Visible = false;
            transferlbl.Visible = false;
            transferbtn.Visible = false;
            transfertxt.Visible = false;
            numerocuenta.Visible = false;
            textotransfer.Visible = false;
            cuentadif.Visible = false;


            //muestra el inicio saliendose de todo

            label2.Visible = true;  
            textBox1.Visible = true; 
            botoncuenta.Visible = true;

        }
    }
}
