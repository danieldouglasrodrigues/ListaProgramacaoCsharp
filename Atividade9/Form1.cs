using System;
using System.Windows.Forms;

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
            const int N = 4;

            int[,] matriz = new int[N, N]
            {
                { 1,  2,  3,  4  }, 
                { 5,  6,  7,  8  }, 
                { 9,  10, 11, 12 }, 
                { 13, 14, 15, 16 }  
            };

            long somaDiagonalPrincipal = 0;
            long somaDiagonalSecundaria = 0;

            for (int i = 0; i < N; i++)
            {
                somaDiagonalPrincipal += matriz[i, i];

                int jSecundaria = N - 1 - i;
                somaDiagonalSecundaria += matriz[i, jSecundaria];
            }

            string mensagem = "## Análise da Matriz 4x4 ##\n\n";
            mensagem += $"A matriz inicializada é:\n";
            mensagem += $"{{ {matriz[0, 0],2}, {matriz[0, 1],2}, {matriz[0, 2],2}, {matriz[0, 3],2} }}\n";
            mensagem += $"{{ {matriz[1, 0],2}, {matriz[1, 1],2}, {matriz[1, 2],2}, {matriz[1, 3],2} }}\n";
            mensagem += $"{{ {matriz[2, 0],2}, {matriz[2, 1],2}, {matriz[2, 2],2}, {matriz[2, 3],2} }}\n";
            mensagem += $"{{ {matriz[3, 0],2}, {matriz[3, 1],2}, {matriz[3, 2],2}, {matriz[3, 3],2} }}\n\n";

            mensagem += "----------------------------------------------\n";
            mensagem += $"1. Soma da Diagonal Principal:\n  => {somaDiagonalPrincipal}\n\n";
            mensagem += $"2. Soma da Diagonal Secundária:\n  => {somaDiagonalSecundaria}";
            mensagem += "\n----------------------------------------------";

            MessageBox.Show(mensagem, "Resultado do Cálculo de Diagonais", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}