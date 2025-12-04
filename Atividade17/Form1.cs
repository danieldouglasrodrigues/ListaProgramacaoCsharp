using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic; 

namespace Atividade17
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DemonstrarProduto();
        }

        private void DemonstrarProduto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("## Demonstração da Classe Produto ##");
            sb.AppendLine("--------------------------------------------------");

            string nome = Interaction.InputBox("Digite o nome do Produto:", "Entrada de Dados", "Teclado Mecânico");

            double preco = 0.0;
            string inputPreco = Interaction.InputBox($"Digite o preço unitário de {nome}:", "Entrada de Dados", "450.50");
            if (double.TryParse(inputPreco, out double p))
            {
                preco = p;
            }

            int quantidade = 0;
            string inputQuantidade = Interaction.InputBox($"Digite a quantidade em estoque de {nome}:", "Entrada de Dados", "15");
            if (int.TryParse(inputQuantidade, out int q))
            {
                quantidade = q;
            }

            Produto meuProduto = new Produto
            {
                Nome = nome,
                Preco = preco,
                QuantidadeEmEstoque = quantidade
            };

            double valorTotal = meuProduto.CalcularValorTotalEmEstoque();

            sb.AppendLine($"Produto: {meuProduto.Nome}");
            sb.AppendLine($"Preço Unitário: R$ {meuProduto.Preco:F2}");
            sb.AppendLine($"Quantidade em Estoque: {meuProduto.QuantidadeEmEstoque}");
            sb.AppendLine("--------------------------------------------------");
            sb.AppendLine($"VALOR TOTAL EM ESTOQUE: R$ {valorTotal:F2}");
            sb.AppendLine("--------------------------------------------------");

            MessageBox.Show(sb.ToString(), $"Cálculo de Estoque - {meuProduto.Nome}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }

        public double CalcularValorTotalEmEstoque()
        {
            return Preco * QuantidadeEmEstoque;
        }
    }
}