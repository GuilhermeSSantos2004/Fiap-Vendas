namespace Fiap.Vendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            validarUsuario(txtName.Text, txtPassword.Text);
        }

        private void validarUsuario(string usuario, string senha)
        {
            if(usuario =="fiap" &&  senha =="2025") 
            {
                Inicio telaNova = new Inicio();
                telaNova.Show();
            }
            else
            {
                MessageBox.Show("Usuário/senha inválidos");
            }
            
        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
