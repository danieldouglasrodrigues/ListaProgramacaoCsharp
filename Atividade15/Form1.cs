using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic; 

namespace Atividade15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsPrime(int number)
        {
            if (number <= 1) return false; 
            if (number == 2) return true;  
            if (number % 2 == 0) return false; 

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int numeroN = -1;
            bool entradaValida = false;

            while (!entradaValida)
            {
                string entradaN = Interaction.InputBox(
                    "Digite um número inteiro positivo (N) para verificar se é primo:",
                    "Verificador de Número Primo",
                    "17"
                );

                if (string.IsNullOrEmpty(entradaN))
                {
                    MessageBox.Show("Operação cancelada. É necessário um número para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (int.TryParse(entradaN, out numeroN) && numeroN > 0)
                {
                    entradaValida = true;
                }
                else
                {
                    MessageBox.Show("Entrada inválida. Digite um número inteiro POSITIVO.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            bool isPrimo = IsPrime(numeroN);

            string resultadoLiteral = isPrimo ? "TRUE" : "FALSE";
            string classificacao = isPrimo ? "O número é primo. Ele é divisível apenas por 1 e por ele mesmo." : "O número NÃO é primo. Ele possui outros divisores além de 1 e ele mesmo.";

            string mensagem = "## Verificador de Número Primo ##\n\n";
            mensagem += $"Número N Informado: {numeroN}\n\n";
            mensagem += "-----------------------------------------\n";
            mensagem += $"Resultado Booleano: {resultadoLiteral}\n";
            mensagem += $"Classificação: {classificacao}";
            mensagem += "\n-----------------------------------------";

            MessageBox.Show(mensagem, "Resultado da Verificação de Primo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}