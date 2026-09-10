
namespace LojaDocinhos
{
    public class Doces
    {
        public string? NomeDoce { get; set; }

        public double PrecoUnitario { get; set; }

        public int Quantidade { get; set; }

        public int IdadeCliente { get; set; }


        public double CalcularDesconto()
        {
            double valorTotal = PrecoUnitario * Quantidade;

            if (Quantidade >= 10)
            {
                return valorTotal * 0.10;

            }
            
            return 0.0;
        }

        public double CalcularValorFinal()
        {
            double valorTotalBruto = PrecoUnitario * Quantidade;
            double desconto = CalcularDesconto();
            return valorTotalBruto - desconto;
        }

        public double CalcularParcela()
        {
            return CalcularValorFinal() / 3.0;
        }

        public bool ValidarBrinde()
        {
            return (IdadeCliente >= 18 && Quantidade >= 5) || (CalcularValorFinal() > 100.0);
        }
    } 
}
