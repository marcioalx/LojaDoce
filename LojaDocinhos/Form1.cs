namespace LojaDocinhos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Doces pedido = new Doces();

                pedido.NomeDoce = txtNomeDoce.Text;
                pedido.PrecoUnitario = Convert.ToDouble(txtPrecoUnitario.Text);
                pedido.Quantidade = int.Parse(txtQuantidade.Text);
                pedido.IdadeCliente = int.Parse(txtIdadeCliente.Text);

                double desconto = pedido.CalcularDesconto();
                double valorFinal = pedido.CalcularValorFinal();
                double parcela = pedido.CalcularParcela();
                bool brindeAprovado = pedido.ValidarBrinde();

                lblNome.Text = $"{pedido.NomeDoce.ToUpper()}";
                lblDesconto.Text = $"R${desconto:N2}";
                lblValorFinal.Text = $"R${valorFinal:N2}";
                lblParcela.Text = $"3x de R$ {parcela:N2}";

                txtNomeDoce.Clear();
                txtPrecoUnitario.Clear();
                txtQuantidade.Clear();
                txtIdadeCliente.Clear();

                if (brindeAprovado)
                {
                    lblStatus.Text = "PARABÉNS! Você ganhou um brinde surpresa!";
                    lblStatus.ForeColor = Color.Red;
                }
                else
                {
                    lblStatus.Text = "Compra padrão realizada com sucesso!";
                    lblStatus.ForeColor = Color.Blue;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Preencha os campos numéricos corretamente!",
                    "Erro de Digitação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }
    }
}
