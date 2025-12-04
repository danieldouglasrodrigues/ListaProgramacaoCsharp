using System;
using System.Text;
using System.Windows.Forms;
// O namespace Microsoft.VisualBasic não é mais necessário para este exercício, mas é mantido se outras partes do seu projeto o usarem.

namespace Atividade13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Este evento é disparado quando o formulário é carregado.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Dimensões da Matriz Original (Linhas x Colunas)
            const int LINHAS_ORIGINAL = 2;
            const int COLUNAS_ORIGINAL = 3;

            // 1. Declaração e Inicialização da Matriz Original (2x3)
            int[,] matrizOriginal = new int[LINHAS_ORIGINAL, COLUNAS_ORIGINAL]
            {
                { 1, 2, 3 },    // Linha 0
                { 4, 5, 6 }     // Linha 1
            };

            // Dimensões da Matriz Transposta (Colunas Original x Linhas Original)
            const int LINHAS_TRANSPOSTA = COLUNAS_ORIGINAL; // 3
            const int COLUNAS_TRANSPOSTA = LINHAS_ORIGINAL; // 2

            // Criação da Matriz Transposta (3x2)
            int[,] matrizTransposta = new int[LINHAS_TRANSPOSTA, COLUNAS_TRANSPOSTA];

            // --- 2. Geração da Matriz Transposta ---
            // Linhas da original (i) se tornam Colunas da transposta
            // Colunas da original (j) se tornam Linhas da transposta
            for (int i = 0; i < LINHAS_ORIGINAL; i++) // 0 a 1
            {
                for (int j = 0; j < COLUNAS_ORIGINAL; j++) // 0 a 2
                {
                    // A regra da transposição: Transposta[j, i] = Original[i, j]
                    matrizTransposta[j, i] = matrizOriginal[i, j];
                }
            }

            // --- 3. Exibição dos Resultados (MessageBox) ---

            // Função auxiliar para formatar a matriz como string
            Func<int[,], int, int, string> formatarMatriz = (matriz, linhas, colunas) =>
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < linhas; i++)
                {
                    sb.Append("{ ");
                    for (int j = 0; j < colunas; j++)
                    {
                        sb.Append($"{matriz[i, j],2}{(j < colunas - 1 ? ", " : "")}");
                    }
                    sb.AppendLine(" }");
                }
                return sb.ToString();
            };

            // Constrói a mensagem final
            string mensagem = "## Matriz Transposta ##\n\n";

            mensagem += $"Matriz Original ({LINHAS_ORIGINAL} x {COLUNAS_ORIGINAL}):\n";
            mensagem += formatarMatriz(matrizOriginal, LINHAS_ORIGINAL, COLUNAS_ORIGINAL);

            mensagem += "\n------------------------------------------------\n";

            mensagem += $"Matriz Transposta ({LINHAS_TRANSPOSTA} x {COLUNAS_TRANSPOSTA}):\n";
            mensagem += formatarMatriz(matrizTransposta, LINHAS_TRANSPOSTA, COLUNAS_TRANSPOSTA);

            mensagem += "\n------------------------------------------------\n";
            mensagem += "A transposta é gerada trocando-se linhas por colunas (Original[i, j] -> Transposta[j, i]).";

            // Exibe a mensagem de forma amigável
            MessageBox.Show(mensagem, "Cálculo da Matriz Transposta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}