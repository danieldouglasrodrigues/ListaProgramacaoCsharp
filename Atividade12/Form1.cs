using System;
using System.Windows.Forms;
using Microsoft.VisualBasic; 

namespace Atividade12
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
            const int COLUNAS = 4;

            int[,] matriz = new int[LINHAS, COLUNAS]
            {
                { 1, 5, 9, 12 },    
                { 2, 6, 10, 15 },   
                { 3, 7, 11, 20 }   
            };

            int linhaDesejada = -1;
            bool entradaValida = false;

            long somaLinha = 0;

            while (!entradaValida)
            {
                string entrada = Interaction.InputBox(
                    "Digite o índice da linha que deseja somar (0, 1 ou 2):",
                    "Seleção de Linha",
                    "0" 
                );

                if (string.IsNullOrEmpty(entrada))
                {
                    MessageBox.Show("Operação cancelada pelo usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (int.TryParse(entrada, out int linha) && linha >= 0 && linha < LINHAS)
                {
                    linhaDesejada = linha;
                    entradaValida = true;
                }
                else
                {
                    MessageBox.Show("Entrada inválida. Digite 0, 1 ou 2.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            for (int j = 0; j < COLUNAS; j++)
            {
                somaLinha += matriz[linhaDesejada, j];
            }

            string representacaoMatriz = "";
            for (int i = 0; i < LINHAS; i++)
            {
                representacaoMatriz += (i == linhaDesejada ? "-> " : "   "); 
                representacaoMatriz += "{ ";
                for (int j = 0; j < COLUNAS; j++)
                {
                    representacaoMatriz += $"{matriz[i, j],3}{(j < COLUNAS - 1 ? ", " : "")}";
                }
                representacaoMatriz += " }\n";
            }

            string mensagem = "## Soma de Elementos por Linha ##\n\n";
            mensagem += $"A matriz 3x4 inicializada é:\n{representacaoMatriz}\n";
            mensagem += "----------------------------------------------\n";
            mensagem += $"Linha Escolhida (Índice): {linhaDesejada}\n";
            mensagem += $"Soma Total dos Elementos na Linha {linhaDesejada}: {somaLinha}";
            mensagem += "\n----------------------------------------------";

            MessageBox.Show(mensagem, "Resultado da Soma da Linha", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}