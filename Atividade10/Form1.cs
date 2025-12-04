namespace Atividade10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const int LINHAS = 3;
            const int COLUNAS = 5;

            int[,] matriz = new int[LINHAS, COLUNAS]
            {
                { 10, 20, 5, 40, 15 },    
                { 55, 99, 30, 75, 25 },   
                { 80, 12, 60, 45, 90 }    
            };

            int valorMaximo = int.MinValue;
            int linhaMax = -1;
            int colunaMax = -1;

            for (int i = 0; i < LINHAS; i++) 
            {
                for (int j = 0; j < COLUNAS; j++) 
                {
                    if (matriz[i, j] > valorMaximo)
                    {
                        valorMaximo = matriz[i, j]; 
                        linhaMax = i;              
                        colunaMax = j;             
                    }
                }
            }


            string representacaoMatriz = "";
            for (int i = 0; i < LINHAS; i++)
            {
                representacaoMatriz += "{ ";
                for (int j = 0; j < COLUNAS; j++)
                {
                    representacaoMatriz += $"{matriz[i, j],3}{(j < COLUNAS - 1 ? ", " : "")}";
                }
                representacaoMatriz += " }\n";
            }

            string mensagem = "## Análise de Matriz (3 x 5) ##\n\n";
            mensagem += $"A matriz inicializada é:\n{representacaoMatriz}\n";
            mensagem += "----------------------------------------------\n";
            mensagem += $"Valor Máximo Encontrado: {valorMaximo}\n";
            mensagem += $"Posição do Valor Máximo:\n";
            mensagem += $"  - Linha (i): {linhaMax}\n";
            mensagem += $"  - Coluna (j): {colunaMax}";
            mensagem += "\n----------------------------------------------";

            MessageBox.Show(mensagem, "Resultado da Busca por Valor Máximo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
