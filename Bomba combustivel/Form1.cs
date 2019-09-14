using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomba_combustivel
{
    public partial class Form1 : Form
    {
        private Combustivel combustivel;

        public Form1()
        {
            InitializeComponent();
            combustivel = new Combustivel();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combustivel.Tipo = "Gasolina";
            combustivel.Preco = 4.35;
            combustivel.Quantidade = 1000;

            textoTipo.Text = combustivel.Tipo;
            textoQuantidade.Text = Convert.ToString(combustivel.Quantidade);
            textoPreco.Text = Convert.ToString(combustivel.Preco);

            textoAlterarPreco.Text = Convert.ToString(combustivel.Preco);
            textoAlterarTipo.Text = combustivel.Tipo;
        }

        private void BtnAbasteceValor_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textoEntrada.Text);
            textoEntrada.Text = null;
            double quantidadeAbastece = combustivel.AbastecePorValor(valor);
            textoQuantidade.Text = Convert.ToString(combustivel.Quantidade.ToString("F4"));
            MessageBox.Show("Quantidade a ser abastecido: " + quantidadeAbastece.ToString("F4") + " litros");
        }

        private void BtnAbasteceQuantidade_Click(object sender, EventArgs e)
        {
            double quantidade = Convert.ToDouble(textoEntrada.Text);
            textoEntrada.Text = null;
            double valor = combustivel.AbastecePorQuantidade(quantidade);
            textoQuantidade.Text = Convert.ToString(combustivel.Quantidade);
            MessageBox.Show("Valor a pagar: " + valor.ToString("F4") + " reais");
        }

        private void BtnEntradaCombustivel_Click(object sender, EventArgs e)
        {
            double qtdEntrada = Convert.ToDouble(textoEntradaCombustivel.Text);
            combustivel.EntradaCombustivel(qtdEntrada);
            textoQuantidade.Text = Convert.ToString(combustivel.Quantidade);
            textoEntradaCombustivel.Text = null;
            MessageBox.Show("Entrada com sucesso!");
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textoAlterarPreco.Text);
            combustivel.AlterarCombustivel(textoAlterarTipo.Text);
            combustivel.AlterarValor(valor);

            textoPreco.Text = Convert.ToString(combustivel.Preco);
            textoTipo.Text = combustivel.Tipo;

            MessageBox.Show("Salvo com sucesso!");
        }

        private void TextoEntrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextoEntradaCombustivel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
