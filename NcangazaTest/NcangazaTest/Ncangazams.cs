namespace NcangazaTest
{
    public partial class Ncangazams : Form
    {
        public Ncangazams()
        {
            InitializeComponent();
        }

        private void bem_vindo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Ncangazams_Load(object sender, EventArgs e)
        {
            // Adicionar itens ao ComboBox
            comboBox1.Items.Add("Chefe");
            comboBox1.Items.Add("Operador");
            comboBox1.Items.Add("Administrador");

            // Opcional: Definir o primeiro item como selecionado por padrão
            comboBox1.SelectedIndex = 0;

            // Configurar o TextBox para ocultar a senha
            textBox3.PasswordChar = '*';
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Implementar lógica aqui, se necessário
        }
    }
}
