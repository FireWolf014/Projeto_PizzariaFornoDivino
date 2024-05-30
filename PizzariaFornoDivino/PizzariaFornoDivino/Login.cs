namespace PizzariaFornoDivino
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Exitebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
           
            
            if (txtUser.Text == "admin" && txtSenha.Text == "admin")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario e senha incorretos");
            }
        }
    }
}
