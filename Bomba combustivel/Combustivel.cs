using System.Windows.Forms;

namespace Bomba_combustivel
{
    internal class Combustivel
    {
        public string Tipo { get; internal set; }
        public double Preco { get; internal set; }
        public double Quantidade { get; internal set; }

        public double AbastecePorValor(double valor)
        {
            double quantidadeAbastece = valor / Preco;
            if(quantidadeAbastece <= Quantidade)
            {
                Quantidade -= quantidadeAbastece;
                return quantidadeAbastece;
            }
            return 0;
        }

        public double AbastecePorQuantidade(double quantidade)
        {
            double valor = Preco * quantidade;
            if(quantidade <= this.Quantidade)
            {
                this.Quantidade -= quantidade;
                return valor;
            }
            return 0;
        }

        public void AlterarValor(double valor)
        {
            Preco = valor;
        }

        public void AlterarCombustivel(string tipo)
        {
            this.Tipo = tipo;
        }

        public void EntradaCombustivel(double quantidade)
        {
            this.Quantidade += quantidade;
        }
    }
}