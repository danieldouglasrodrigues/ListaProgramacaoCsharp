namespace Atividade11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const int LINHAS = 4;
            const int COLUNAS = 3;

            int[,] matriz = new int[LINHAS, COLUNAS]
            {
                {  5,  -10,  0  },    
                { 15,    2, -20 },    
                {  0,   -5,  30 },    
                { -8,   45,   1 }     
            };

            int countPositivos = 0;
            int countNegativos = 0;
            int countZeros = 0;

            for (int i = 0; i < LINHAS; i++) 
            {
                for (int j = 0; j < COLUNAS; j++) 
                {
                    int elemento = matriz[i, j];

                    if (elemento > 0)
                    {
                        countPositivos++;
                    }
                    else if (elemento < 0)
                    {
                        countNegativos++;
                    }
                    else
                    {
                        countZeros++;
                    }
                }
            }

            string representacaoMatriz = "";
            for (int i = 0; i < LINHAS; i++)
            {
                representacaoMatriz += "{ ";
                for (int j = 0; j < COLUNAS; j++)
                {
                    representacaoMatriz += $"{matriz[i, j],4}{(j < COLUNAS - 1 ? ", " : "")}";
                }
                representacaoMatriz += " }\n";
            }

            string mensagem = "## Análise de Matriz (4 x 3) - Contagem ##\n\n";
            mensagem += $"A matriz inicializada é:\n{representacaoMatriz}\n";
            mensagem += "----------------------------------------------\n";
            mensagem += $"Resultados da Contagem:\n";
            mensagem += $"  1. Elementos Positivos (> 0): {countPositivos}\n"; 
            mensagem += $"  2. Elementos Negativos (< 0): {countNegativos}\n"; 
            mensagem += $"  3. Elementos Iguais a Zero (= 0): {countZeros}";    
            mensagem += "\n----------------------------------------------";

            MessageBox.Show(mensagem, "Resultado da Análise de Elementos da Matriz", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
