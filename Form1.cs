namespace Act2_86329
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            //Validamos que se ingrese un usuario
            if ((txt_usuario.Text == ""))
            {
                MessageBox.Show("Se debe ingresar un usuario");
                return;
            }

            if ((txt_pwd.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña");
                return;
            }
            MessageBox.Show("Usted a ingresado al sistema");
            this.Close();
        }
    }
}