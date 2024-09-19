namespace Atividade_Versionamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtValor1.Text);
            double valor2 = Convert.ToDouble(txtValor2.Text);
            double resultado = valor1 + valor2;
            txtResultado.Text = resultado.ToString();
        }
    }
}
